namespace Chronica.Models
{
    public class PersonagemSubHabilidade
    {
        public int PersonagemId { get; set; }
        public Personagem Personagem { get; set; }

        public int SubHabilidadeId { get; set; }
        public SubHabilidade SubHabilidade { get; set; }
    }
}