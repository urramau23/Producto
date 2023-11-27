namespace Productos.Core.Entities.DTO
{
    public class Parametros
    {
        public string Simbolo_Peso { get; set; }
        public string Simbolo_Dolar { get; set; }
        public int[] TipoCuenta_CA { get; set; }
        public int[] TipoCuenta_CC { get; set; }
        public int BIN_Visa { get; set; }
        public int BIN_Master { get; set; }
        public bool InformaDisponibleVisa { get; set; }
        public bool InformaDisponibleMaster { get; set; }
    }
}
