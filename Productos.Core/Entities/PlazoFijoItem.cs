namespace Productos.Core.Entities
{
    public class PlazoFijoItem
    {
        public string id_plazo_fijo { get; set; }
        public string tipo_pf { get; set; }
        public string descripcion_pf { get; set; }
        public decimal importe { get; set; }
        public string codigo_moneda { get; set; }
        public string descripcion_moneda { get; set; }
        public decimal tna { get; set; }
        public decimal intereses_totales { get; set; }
        public string vencimiento_pf { get; set; }
    }
}
