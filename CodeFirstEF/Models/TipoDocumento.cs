namespace CodeFirstEF.Models
{
    public class TipoDocumento
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public int Estado { get; set; } = 0;
        public HashSet<Proveedores> Proveedores { get; set;} = new HashSet<Proveedores>();
    }
}
