using CodeFirstEF.Models;

namespace CodeFirstEF.DTOs
{
    public class ProductosCreacionDTO
    {
        public string Nombre { get; set; } = null!;
        public decimal StockMin { get; set; }
        public decimal StockMax { get; set;}
        public DateTime FechaCreacion { get; set; } = new DateTime();
        public DateTime FechaModificacion { get; set; } = new DateTime();
        public int MarcasId { get; set; }
        public int UnidadesDeMedidaId { get; set; }
        public int CategoriaProductoId { get; set;}
        public List<StockProductoCreacionDTO> StockProducto { get; set; } = new List<StockProductoCreacionDTO>();
    }
}
