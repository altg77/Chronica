using System.ComponentModel.DataAnnotations.Schema;
using Chronica.Models.Relacoes;

namespace Chronica.Models.Universe
{
    public class Desvantagens
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        [Column(TypeName = "TEXT")] // For potentially long descriptions
        public string Descricao { get; set; }

        // Coleção para o relacionamento Muitos-para-Muitos com Personagem
        public ICollection<PersonagemDesvantagem> PersonagemDesvantagens { get; set; } = new List<PersonagemDesvantagem>();

    }
}