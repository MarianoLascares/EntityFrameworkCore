namespace CodeFirstEF.Models
{
    public class ProveedorRubros
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Estado { get; set; } = 0;
        public HashSet<Proveedores> Proveedores { get; set; } = new HashSet<Proveedores>();
    }
}
