namespace CodeFirstEF.Models
{
    public class Almacenes
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int Estado { get; set; } = 0;
        public virtual HashSet<StockProducto> StockProducto { get; set; } = null!;
        public virtual ICollection<EncEntradaProductos> EncEntradaProductos { get; set; } = null!;
    }
}
