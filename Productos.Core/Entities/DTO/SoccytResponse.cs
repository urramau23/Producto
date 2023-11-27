using System;
using System.Collections.Generic;
using System.Text;

namespace Productos.Core.Entities.DTO
{
    public class SoccytResponse
    {
        public SoccytResponse(string xml) 
        {
            Resultado = new SoccytResultadoResponse(xml);
            Tarjetas = new SoccytRecord1Response(xml);
        }
        public SoccytResponse()
        {
        }

        public SoccytResultadoResponse Resultado { get; set; }
        public SoccytRecord1Response Tarjetas { get; set; }
    }
}
