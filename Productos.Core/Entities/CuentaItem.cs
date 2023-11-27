namespace Productos.Core.Entities
{
    public class CuentaItem
    {
        public string tipo_cuenta { get; set; }
        public string descripcion_cuenta { get; set; }
        public string descripción_corta { get; set; }
        public string numero_cuenta { get; set; }
        public string codigo_moneda { get; set; }
        public string descripcion_moneda { get; set; }
        public string tarjeta_debito_asociada { get; set; }
        public SaldoItem saldo{ get; set; }
    }
}
