namespace CodeFirstEF.Models
{
    public class Ciudades
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int Estado { get; set; } = 0;
        public HashSet<Proveedores> Proveedores { get; set;} = new HashSet<Proveedores>();
        public int DepartamentosId { get; set; }
        public Departamentos DepartamentosNavigation { get; set; } = null!;
    }
}
