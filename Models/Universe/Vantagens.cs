using System.ComponentModel.DataAnnotations.Schema;
using Chronica.Models.Relacoes;

namespace Chronica.Models.Universe
{
    public class Vantagens
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        [Column(TypeName = "TEXT")] // For potentially long descriptions
        public string Descricao { get; set; }


        // Coleção para o relacionamento Muitos-para-Muitos com Personagem
        public ICollection<PersonagemVantagem> PersonagemVantagens { get; set; } = new List<PersonagemVantagem>();

    }
}