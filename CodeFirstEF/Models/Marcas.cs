namespace CodeFirstEF.Models
{
    public class Marcas
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int Estado { get; set; } = 0;
        public virtual HashSet<Productos> ProductosNavigation { get; set; } = new HashSet<Productos>();
    }
}
