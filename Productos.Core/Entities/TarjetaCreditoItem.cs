namespace Productos.Core.Entities
{
    public class TarjetaCreditoItem
    {
        public string tipo { get; set; }
        public string descripcion { get; set; }
        public string marca { get; set; }
        public string numero { get; set; }
        public string fecha_vencimiento_tarjeta { get; set; }
        public decimal saldo_disponible { get; set; }
        public string fecha_cierre { get; set; }
        public decimal saldo_a_pagar_pesos { get; set; }
        public decimal saldo_a_pagar_dolares { get; set; }
        public string estado { get; set; }
        public string rol { get; set; }
    }
}
