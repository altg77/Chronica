using System.ComponentModel.DataAnnotations.Schema;

namespace Chronica.Models
{
    public class Pericia
    {
        public int Id { get; set; }
        public string Nome { get; set; }

         [Column(TypeName = "TEXT")] 
        public string Descricao { get; set; }
        public string Atributo { get; set; }
        public ICollection<PersonagemPericia> PersonagemPericias { get; set; } = new List<PersonagemPericia>(); // Changed to PersonagemPericia
    }
}