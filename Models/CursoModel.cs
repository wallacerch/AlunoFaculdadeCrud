using System.ComponentModel.DataAnnotations;

namespace AlunoFaculdadeCrud.Models
{
    public class CursoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do curso é obrigatório.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O curso deve conter entre 3 e 100 caracteres.")]
        public string Nome { get; set; }
    }
}