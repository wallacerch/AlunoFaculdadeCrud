using System.ComponentModel.DataAnnotations;

namespace AlunoFaculdadeCrud.Models
{
    public class AlunoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do aluno é obrigatório.")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O nome deve conter entre 3 e 255 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O email é obrigatório.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "O email deve conter entre 5 e 100 caracteres.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O CPF do aluno é obrigatório.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF deve conter 11 caracteres.")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "A matrícula do aluno é obrigatória.")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "A matrícula deve conter 11 caracteres.")]
        public string Matricula { get; set; }
        public CursoModel Curso { get; set; }

        [Required(ErrorMessage = "O turno do aluno é obrigatório.")]
        [StringLength(5, MinimumLength = 5, ErrorMessage = "O curso deve conter 5 caracteres.")]
        public string Turno { get; set; }
    }
}