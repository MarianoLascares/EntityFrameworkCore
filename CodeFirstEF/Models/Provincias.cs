namespace CodeFirstEF.Models
{
    public class Provincias
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int Estado { get; set; } = 0;
        public HashSet<Departamentos> Departamentos { get; set;} = new HashSet<Departamentos>();
    }
}
