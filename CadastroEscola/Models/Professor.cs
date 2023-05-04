using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroEscola.Models
{
    public class Professor
    {
        [Key]
        public int IdProfessor { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public DateTime Nascimento { get; set; }
        [ForeignKey(nameof(IdMateria))]
        public int IdMateria { get; set;}
        
    }
}
