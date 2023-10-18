namespace CodeFirstEF.Models
{
    public class Proveedores
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Celular { get; set; }
        public string Direccion { get; set; } = null!;
        public string Observacion { get; set; } = null!;
        public DateTime FechaCreachion { get; set; } = new DateTime();
        public int Estado { get; set; } = 0;
        public int TipoDocumentoId { get; set; }
        public TipoDocumento TipoDocumentoNavigation { get; set; } = null!;
        public int ProveedorRubrosId { get; set; }
        public HashSet<ProveedorRubros> ProveedorRubrosNavigation { get; set; } = new HashSet<ProveedorRubros>();
        public int SexoId { get; set; }
        public Sexo SexoNavigation { get; set; } = null!;
        public int CiudadesId { get; set; }
        public Ciudades CiudadesNavigation { get; set; } = null!;
        public virtual ICollection<EncEntradaProductos> EncEntradaProductos { get; set; } 
            = null!;
    }
}
