using System.ComponentModel.DataAnnotations;

namespace EmprestimoLivros.Models
{
    public class EmprestimosModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo obrigatório")]
        public string Recebedor { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Fornecedor { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string LivroEmprestado { get; set; }

        public DateTime dataUltimaAtualizacao { get; set; } = DateTime.Now;

    }
}
