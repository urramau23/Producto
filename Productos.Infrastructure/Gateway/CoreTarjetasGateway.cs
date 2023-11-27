using Microsoft.Extensions.Logging;
using Productos.Core.Entities.DTO;
using Productos.Core.Entities.Exceptions;
using Productos.Core.Interfaces;
using System.Xml;

namespace Productos.Infrastructure.Gateway
{
    public class CoreTarjetasGateway : ICoreTarjetasGateway
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<CoreTarjetasGateway> _log;

        public CoreTarjetasGateway(IHttpClientFactory httpClientFactory, 
            ILogger<CoreTarjetasGateway> log)
        {
            _httpClientFactory = httpClientFactory;
            _log = log;
        }

        public async Task<SocdoxResponse> SOCDOX(string sexo, string documento)
        {
            string datos = "";
            SocdoxResponse oSocdox = new SocdoxResponse();
            var _httpClient = _httpClientFactory.CreateClient(HttpClientNames.CoreTarjeta);
            string parametro = $"SOCDOX?pDocumento={documento}&pSexo={sexo}";
            var request = await _httpClient.GetAsync(parametro);
            if (!request.IsSuccessStatusCode)
            {
                throw new InternalServerErrorException("ERROR_SOCDOX", "URL: " + request.RequestMessage.RequestUri + " Error: " + request.Content.ReadAsStringAsync().Result);
            }

            var responsexml = request.Content.ReadAsStringAsync().Result;

            XmlDocument oDom =  new XmlDocument();
            oDom.LoadXml(responsexml);
            var resultado = Convert.ToBoolean(oDom.SelectSingleNode("//ELEMENT").Attributes.GetNamedItem("resultado").Value);
            if(resultado)
            {
                datos = oDom.SelectSingleNode("//ELEMENT").Attributes.GetNamedItem("datos").Value;
                oSocdox = new SocdoxResponse(datos);
            }
            else
            {
                string error = oDom.SelectSingleNode("//ELEMENT").Attributes.GetNamedItem("errores").Value;
                if(error.ToUpper().IndexOf("NO EXISTEN TARJETAS PARA LOS DATOS SOLICITADOS") == -1)
                    throw new InternalServerErrorException("ERROR_SOCDOX", "URL: " + request.RequestMessage.RequestUri + " Error: " + error);
            }

            return oSocdox;
        }

        public async Task<SoccytResponse> SOCCYT(string marcacodi, string cuenta)
        {
            SoccytResponse respuesta = new SoccytResponse();
            string datos = "";
            var _httpClient = _httpClientFactory.CreateClient(HttpClientNames.CoreTarjeta);
            string parametro = $"SOCCYT?marcacodi={marcacodi}&cuenta={cuenta}";
            var request = await _httpClient.GetAsync(parametro);
            if (!request.IsSuccessStatusCode)
            {
                throw new InternalServerErrorException("ERROR_SOCCYT", "URL: " + request.RequestMessage.RequestUri + " Error: " + request.Content.ReadAsStringAsync().Result);
            }

            var responsexml = request.Content.ReadAsStringAsync().Result;

            XmlDocument oDom = new XmlDocument();
            oDom.LoadXml(responsexml);
            var resultado = Convert.ToBoolean(oDom.SelectSingleNode("//ELEMENT").Attributes.GetNamedItem("resultado").Value);
            if (resultado)
            {
                datos = oDom.SelectSingleNode("//ELEMENT").Attributes.GetNamedItem("datos").Value;
                respuesta = new SoccytResponse(datos);

            }
            else
                throw new InternalServerErrorException("ERROR_SOCCYT", "URL: " + request.RequestMessage.RequestUri + " Error: " + oDom.SelectSingleNode("//ELEMENT").Attributes.GetNamedItem("errores").Value);

            return respuesta;
        }

        public async Task<SomlydWebResponse> SOMLYD_WEB(string tarjenume)
        {
            SomlydWebResponse respuesta = new SomlydWebResponse();
            string datos = "";
            var _httpClient = _httpClientFactory.CreateClient(HttpClientNames.CoreTarjeta);
            string parametro = $"SOMLYD_WEB?tarjenume={tarjenume}";
            var request = await _httpClient.GetAsync(parametro);
            if (!request.IsSuccessStatusCode)
            {
                throw new InternalServerErrorException("ERROR_SOMLYD_WEB", "URL: " + request.RequestMessage.RequestUri + " Error: " + request.Content.ReadAsStringAsync().Result);
            }

            var responsexml = request.Content.ReadAsStringAsync().Result;

            XmlDocument oDom = new XmlDocument();
            oDom.LoadXml(responsexml);
            var resultado = Convert.ToBoolean(oDom.SelectSingleNode("//ELEMENT").Attributes.GetNamedItem("resultado").Value);
            if (resultado)
            {
                datos = oDom.SelectSingleNode("//ELEMENT").Attributes.GetNamedItem("datos").Value;
                respuesta = new SomlydWebResponse(datos);

            }
            else
                throw new InternalServerErrorException("ERROR_SOMLYD_WEB", "URL: " + request.RequestMessage.RequestUri + " Error: " + oDom.SelectSingleNode("//ELEMENT").Attributes.GetNamedItem("errores").Value);

            return respuesta;
        }

        public async Task<SovlydWebResponse> SOVLYD_WEB(string tarjenume)
        {
            SovlydWebResponse respuesta = new SovlydWebResponse();
            string datos = "";
            var _httpClient = _httpClientFactory.CreateClient(HttpClientNames.CoreTarjeta);
            string parametro = $"SOVLYD_WEB?tarjenume={tarjenume}";
            var request = await _httpClient.GetAsync(parametro);
            if (!request.IsSuccessStatusCode)
            {
                throw new InternalServerErrorException("ERROR_SOVLYD_WEB", "URL: " + request.RequestMessage.RequestUri + " Error: " + request.Content.ReadAsStringAsync().Result);
            }

            var responsexml = request.Content.ReadAsStringAsync().Result;

            XmlDocument oDom = new XmlDocument();
            oDom.LoadXml(responsexml);
            var resultado = Convert.ToBoolean(oDom.SelectSingleNode("//ELEMENT").Attributes.GetNamedItem("resultado").Value);
            if (resultado)
            {
                datos = oDom.SelectSingleNode("//ELEMENT").Attributes.GetNamedItem("datos").Value;
                respuesta = new SovlydWebResponse(datos);
            }
            else
                throw new InternalServerErrorException("ERROR_SOVLYD_WEB", "URL: " + request.RequestMessage.RequestUri + " Error: " + oDom.SelectSingleNode("//ELEMENT").Attributes.GetNamedItem("errores").Value);

            return respuesta;
        }
    }
}
