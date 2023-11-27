namespace Productos.Core.Entities
{
    public class PrestamoItem
    {
        public string id_prestamo { get; set; }
        public string tipo { get; set; }
        public string descripcion { get; set; }
        public decimal monto { get; set; }
        public decimal saldo { get; set; }
        public string cantidad_cuotas { get; set; }
        public string cuotas_canceladas { get; set; }
        public decimal importe_proxima_cuota { get; set; }
        public string vencimiento_proxima_cuota { get; set; }
        public string dias_mora { get; set; }
    }
}
