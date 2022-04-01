using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalMVCCore.Models
{
    public class Professor
    {
        [Key]
        public int Id { get; set; }
        [Column("nome_professor")]
        public string nome { get; set; }
        public string formacao { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        [NotMapped]
        public DateOnly datanascimento { get; set; }
    }
}
