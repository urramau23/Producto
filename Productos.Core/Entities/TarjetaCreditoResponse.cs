using System.Collections.Generic;

namespace Productos.Core.Entities
{
    public class TarjetaCreditoResponse
    {
        public ICollection<TarjetaCreditoItem> tarjetas { get; set; }
    }
}
