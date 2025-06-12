using Chronica.Models.Universe;

namespace Chronica.Models.Relacoes
{
    public class PersonagemDesvantagem
    {
        public int PersonagemId { get; set; }
        public Personagem Personagem { get; set; }

        public int DesvantagemId { get; set; }
        public Desvantagens Desvantagem { get; set; }
    }
}