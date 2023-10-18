namespace CodeFirstEF.Models
{
    public class Productos
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal StockMin { get; set; }
        public decimal StockMax { get; set;}
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set;}
        public int Estado { get; set; } = 0;
        public int MarcasId { get; set; }
        public virtual Marcas MarcasNavigation { get; set; } = null!;
        public int UnidadesDeMedidaId { get; set; }
        public virtual UnidadesDeMedida UnidadesDeMedidaNavigation { get; set; } = null!;
        public int CategoriaProductoId { get; set; }
        public virtual CategoriaProducto CategoriaProductoNavigation { get; set;} = null!;
        public virtual HashSet<StockProducto> StockProducto { get; set; } = null!;
    }
}
