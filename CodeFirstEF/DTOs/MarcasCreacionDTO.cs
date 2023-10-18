using System.ComponentModel.DataAnnotations;

namespace CodeFirstEF.DTOs
{
    public class MarcasCreacionDTO
    {
        [MaxLength(150)]
        public string Nombre { get; set; } = null!;
    }
}
