namespace CodeFirstEF.Models
{
    public class Departamentos
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int Estado { get; set; } = 0;
        public HashSet<Ciudades> Ciudades { get; set; } = new HashSet<Ciudades>();
        public int ProvinciasId { get; set; }
        public Provincias ProvinciasNavigation { get; set; } = null!;
    }
}
