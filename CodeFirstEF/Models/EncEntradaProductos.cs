namespace CodeFirstEF.Models
{
    public class EncEntradaProductos
    {
        public int Id { get; set; }
        public DateTime FechaEmision { get; set; } = DateTime.Now;
        public string Obsevaciones { get; set; } = null!;
        public decimal Subtotal { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public int Estado { get; set; } = 0;
        public int TiposDocumentosEmitirId { get; set; }
        public TiposDocumentosEmitir TiposDocumentosEmitirNavigation { get; set; } = null!; 
        public int AlmacenesId { get; set; }
        public Almacenes AlmacenesNavigation { get; set; } = null!;
        public int ProveedoresId { get; set; }
        public Proveedores ProveedoresNavigation { get; set;} = null!;
        public ICollection<DetalleEntradaProductos> DetalleEntradaProductosNavigation { get; set; } = new List<DetalleEntradaProductos>();

    }
}
