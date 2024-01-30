using System.ComponentModel.DataAnnotations;

namespace Ecommerce.DTO
{
    public class CategoriaDTO
    {
        public int IdCategoria { get; set; }
        [Required(ErrorMessage = "Ingrese nombre")]
        public string? Nombre { get; set; }
    }
}