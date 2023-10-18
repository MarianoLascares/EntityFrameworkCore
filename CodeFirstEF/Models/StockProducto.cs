namespace CodeFirstEF.Models
{
    public class StockProducto
    {
        public int ProductosId { get; set; }
        public int AlmacenesId { get; set; }
        public Almacenes AlmacenesNavigation { get; set; } = null!;
        public decimal StockInicial { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
