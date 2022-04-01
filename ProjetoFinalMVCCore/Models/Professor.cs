using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalMVCCore.Models
{
    public class Professor
    {
        [Key]
        public int Id { get; set; }
        [Column("nome_professor")]
        [Required(ErrorMessage ="Este campo é obrigatorio!")]
        [DisplayName("Nome")]
        public string nome { get; set; }
        [DisplayName("Formação")]
        [Required(ErrorMessage = "Este campo é obrigatorio!")]
        public string formacao { get; set; }
        [DisplayName("CPF")]
        [Required(ErrorMessage = "Este campo é obrigatorio!")]
        public string cpf { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatorio!")]
        [DisplayName("Email")]
        public string email { get; set; }
        [DisplayName("Data de Nascimento")]
        [NotMapped]
        public DateOnly datanascimento { get; set; }
    }
}
