using System.Collections.Generic;

namespace Productos.Core.Entities
{
    public class ProductoPasivoResponse
    {
        public ICollection<CuentaItem> cuentas { get; set; }
        public ICollection<TarjetaDebitoItem> tarjetas { get; set; }
        public ICollection<PlazoFijoItem> plazos_fijos { get; set; }
    }
}
