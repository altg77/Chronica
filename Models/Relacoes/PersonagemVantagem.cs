using Chronica.Models.Universe;

namespace Chronica.Models.Relacoes
{
    public class PersonagemVantagem
    {
        public int PersonagemId { get; set; }
        public Personagem Personagem { get; set; }

        public int VantagemId { get; set; }
        public Vantagens Vantagem { get; set; } 
    }
}
