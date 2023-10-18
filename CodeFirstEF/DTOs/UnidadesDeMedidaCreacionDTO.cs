using System.ComponentModel.DataAnnotations;

namespace CodeFirstEF.DTOs
{
    public class UnidadesDeMedidaCreacionDTO
    {
        [MaxLength(150)]
        public string Nombre { get; set; } = null!;
        [MaxLength(5)]
        public string Abrebiatura { get; set; } = null!;
    }
}
