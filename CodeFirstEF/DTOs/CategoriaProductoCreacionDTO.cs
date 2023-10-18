using System.ComponentModel.DataAnnotations;

namespace CodeFirstEF.DTOs
{
    public class CategoriaProductoCreacionDTO
    {
        [MaxLength(150)]
        public string Nombre { get; set; } = null!;
    }
}
