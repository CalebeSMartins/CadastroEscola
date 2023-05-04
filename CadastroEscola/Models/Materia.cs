using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroEscola.Models
{
    public class Materia
    {
        [Key]
        public int IdMateria { get; set; }
        public string NomeMateria { get; set; }
        public float Nota { get; set; }
        public float MediaFinal { get; set; }
        public bool Situacao { get; set; }
        [ForeignKey(nameof(IdProfessor))]
        public int IdProfessor { get; set; }
        [ForeignKey(nameof(IdAluno))]
        public int IdAluno { get; set; }

    }
}
