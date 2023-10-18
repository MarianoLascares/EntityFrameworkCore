namespace CodeFirstEF.Models
{
    public class TiposDocumentosEmitir
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public int Estado { get; set; } = 0;
        public ICollection<EncEntradaProductos> EncEntradaProductosNavigation { get; set; } 
            = new List<EncEntradaProductos>();
    }
}
