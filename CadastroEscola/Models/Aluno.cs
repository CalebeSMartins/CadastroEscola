using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroEscola.Models
{
    public class Aluno
    {
        [Key]
        public int IdAluno { get; set; }
        public Guid Matricula { get; private set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public DateTime Nascimento { get; set; }
        [ForeignKey(nameof(Nota))]
        public float Nota { get; set; }
        [ForeignKey(nameof(MediaFinal))]
        public float MediaFinal { get; set; }
    }
}
