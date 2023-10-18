using System.ComponentModel.DataAnnotations;

namespace CodeFirstEF.DTOs
{
    public class AlmacenesCreacionDTO
    {
        [MaxLength(150)]
        public string Nombre { get; set; } = null!;
    }
}
