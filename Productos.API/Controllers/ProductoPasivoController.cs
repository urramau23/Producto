using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Productos.Core.Entities;
using Productos.Core.Entities.DTO;

namespace Productos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoPasivoController : ControllerBase
    {
        private readonly ILogger<ProductoPasivoController> _logger;
        private readonly IOptions<Parametros> _parametros;

        public ProductoPasivoController(ILogger<ProductoPasivoController> logger,
            IOptions<Parametros> parametros)
        {
            _logger = logger;
            _parametros = parametros;   
        }

        [HttpGet("{id_columbia}")]   
        public async Task<IActionResult> ProductosPasivos(int id_columbia)
        {
            var respuesta = new ProductoPasivoResponse();
            respuesta.cuentas = new List<CuentaItem>
            {
                new CuentaItem
                {
                    codigo_moneda ="80",
                    descripcion_moneda= _parametros.Value.Simbolo_Peso,
                    descripcion_cuenta="CUENTA DE AHORROS",
                    descripción_corta="CA",
                    numero_cuenta="400100008843953",
                    tipo_cuenta="CA",
                    saldo = new SaldoItem
                    {
                        valor_disponible = true,
                        valor = 1000000
                    },
                    tarjeta_debito_asociada = "5275580000001808",
                }
            };
            respuesta.tarjetas = new List<TarjetaDebitoItem>
            {
                new TarjetaDebitoItem
                {
                    descripcion_tarjeta = "visa debito",
                    marca = "visa",
                    tipo_tarjeta = "visa_debito",
                    fecha_vencimiento = "06/2024",
                    numero = "5275580000001808"
                }
            };
            respuesta.plazos_fijos = new List<PlazoFijoItem>
            {
                new PlazoFijoItem
                {
                    codigo_moneda ="80",
                    descripcion_moneda="$",
                    descripcion_pf="plazo fijo tradicional",
                    id_plazo_fijo="1234567890",
                    importe=600000,
                    intereses_totales=50123,
                    tna=99,
                    tipo_pf="tradicional",
                    vencimiento_pf="24/11/2024"
                }
            };
            return Ok(respuesta);
        }
    }
}
