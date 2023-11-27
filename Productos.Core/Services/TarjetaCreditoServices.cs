using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Productos.Core.Entities;
using Productos.Core.Entities.DTO;
using Productos.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;

namespace Productos.Core.Services
{
    public class TarjetaCreditoServices : ITarjetaCreditoServices
    {
        private readonly ICoreTarjetasGateway _coreTarjetasGateway;
        private readonly ILogger<TarjetaCreditoServices> _logger;
        private readonly IOptions<Parametros> _parametros;

        public TarjetaCreditoServices(ICoreTarjetasGateway coreTarjetasGateway,
            ILogger<TarjetaCreditoServices> logger,
            IOptions<Parametros> parametros)
        {
            _logger = logger;
            _coreTarjetasGateway = coreTarjetasGateway;
            _parametros = parametros;
        }
        public async Task<TarjetaCreditoResponse> GetTarjetaCreditoAsync(string sexo, string documento)
        {
            TarjetaCreditoResponse tarjetaCreditoResponse = new TarjetaCreditoResponse();
            tarjetaCreditoResponse.tarjetas = new List<TarjetaCreditoItem>();
            int fechaHoy = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));
            //paso 1 busco en socdox
            var cuentasTarjeta = await _coreTarjetasGateway.SOCDOX(sexo, documento);
            if(cuentasTarjeta.Root.ELEMENT != null)
            {
                foreach (var element in cuentasTarjeta.Root.ELEMENT)
                {
                    var tarjetas = await _coreTarjetasGateway.SOCCYT(element.MARCACODI, element.CUENTA);
                    if(tarjetas.Tarjetas.Table.ELEMENT != null)
                    {
                        foreach (var item in tarjetas.Tarjetas.Table.ELEMENT)
                        {
                            // si la tarjeta es de esta persona
                            // si la tarjeta no esta vencida
                            if (Convert.ToInt64(item.DOCUNUME) == Convert.ToInt64(documento)
                                && Convert.ToInt32(item.FECHAPLASTIVENCI) > fechaHoy)
                            {
                                TarjetaCreditoItem tarjetaCreditoItem = new TarjetaCreditoItem();
                                tarjetaCreditoItem.tipo = GetTipoDescripcion(element.MARCACODI, item.TARJETIPO);
                                tarjetaCreditoItem.marca = element.MARCADESCRIP.ToLower();
                                tarjetaCreditoItem.descripcion = item.TARJETIPODESCRI.ToLower();
                                tarjetaCreditoItem.numero = item.TARJENUME;
                                tarjetaCreditoItem.fecha_vencimiento_tarjeta = item.FECHAPLASTIVENCI.Substring(4, 2) + "/" + item.FECHAPLASTIVENCI.Substring(0, 4);
                                tarjetaCreditoItem.saldo_disponible = await GetSaldoDisponible(element.MARCACODI, item.TARJENUME);
                                tarjetaCreditoItem.fecha_cierre = DateTime.ParseExact(tarjetas.Resultado.TableResultado.ELEMENT.FECHACIERRE, "yyyyMMdd", CultureInfo.InvariantCulture).ToString("dd/MM/yyyy");
                                tarjetaCreditoItem.saldo_a_pagar_dolares = Convert.ToDecimal(tarjetas.Resultado.TableResultado.ELEMENT.SALDOACTUALDOLAR);
                                tarjetaCreditoItem.saldo_a_pagar_pesos = Convert.ToDecimal(tarjetas.Resultado.TableResultado.ELEMENT.SALDOACTUALPESOS);
                                tarjetaCreditoItem.estado = "vigente";
                                tarjetaCreditoItem.rol = item.TARJECATEDESCRI.ToLower();
                                tarjetaCreditoResponse.tarjetas.Add(tarjetaCreditoItem);
                            }
                        }
                    }
                }
            }
            
            return tarjetaCreditoResponse;
        }

        private async Task<decimal> GetSaldoDisponible(string marcacodi, string numeroTarjeta)
        {
            if (marcacodi == "1" && _parametros.Value.InformaDisponibleMaster)
            {
                // master
                var limites = await _coreTarjetasGateway.SOMLYD_WEB(numeroTarjeta);
                // negrada para convertir rl decimal porque me llega con , como separador de decimales.
                return Convert.ToDecimal(limites.somlyd.TABLE.ELEMENT.DISPMESUNI.Replace(",","."));
            }
            else if (marcacodi == "2" && _parametros.Value.InformaDisponibleVisa) 
            {
                // visa
                var limites = await _coreTarjetasGateway.SOVLYD_WEB(numeroTarjeta);
                return Convert.ToDecimal(limites.Sovlyd.TABLE.ELEMENT.LIMIDISPCONTADO.Replace(",", "."));
            }
            return 0;
        }

        private string GetTipoDescripcion(string marcacodi, string tarjetipo)
        {
            if(marcacodi == "1") // Master
            {
                switch(tarjetipo)
                {
                    case "3":
                        return "master_gold";
                    case "43":
                        return "master_black";
                    default:
                        return "master_internacional";
                }
            }
            else if (marcacodi == "2") //visa
            {
                switch (tarjetipo)
                {
                    case "P":
                        return "visa_gold";
                    default:
                        return "visa_internacional";
                }
            }
            return "";
        }
    }
}
