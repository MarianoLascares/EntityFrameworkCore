using CodeFirstEF.Models;

namespace CodeFirstEF.DTOs
{
    public class EncEntradaProductosDTO
    {
        public DateTime FechaEmision { get; set; }
        public string Obsevaciones { get; set; } = null!;
        public int TiposDocumentosEmitirId { get; set; }
        public int AlmacenesId { get; set; }
        public int ProveedoresId { get; set; }
        public List<DetalleEntradaProductosDTO> DetalleEntradaProductosNavigation { get; set; } = new List<DetalleEntradaProductosDTO>();
    }
}
