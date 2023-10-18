namespace CodeFirstEF.Models
{
    public class DetalleEntradaProductos
    {
        public int Id { get; set; }
        public int CodigoProducto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal Total { get; set; }
        public int EncEntradaProductosId { get; set; }
        public EncEntradaProductos EncEntradaProductosNavigation { get; set; } = null!;
    }
}
