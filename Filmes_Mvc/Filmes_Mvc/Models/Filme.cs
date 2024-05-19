using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Filmes_Mvc.Models
{
    public class Filme
    {
        [Required]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        [MaxLength(60, ErrorMessage = "O número máximo de caracteres permitido é 60.")]
        [Display(Name = "Título")]
        public string? Titulo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataDeLancamento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        [MaxLength (50, ErrorMessage = "O número máximo de caracteres permitido é 50.")]
        [Display(Name = "Gênero")]
        public string? Genero { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        [DataType (DataType.Currency)]
        [Precision (18, 2)]
        [RegularExpression(@"^\d+(\,\d{1,2})?$", ErrorMessage = "O campo {0} deve ser um valor monetário.")]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
    }
}
