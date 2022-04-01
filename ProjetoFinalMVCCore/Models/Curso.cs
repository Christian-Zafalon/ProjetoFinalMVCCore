using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalMVCCore.Models
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }
        [Column("nome_curso")]
        public string nome { get; set; }
        public string materia { get; set; }
        public string cargaHoraria { get; set; }
        public string nivel { get; set; } 
        public int valor { get; set; }

    }
}
