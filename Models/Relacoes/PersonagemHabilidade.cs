namespace Chronica.Models
{
    public class PersonagemHabilidade
    {
        public int PersonagemId { get; set; }
        public Personagem Personagem { get; set; }

        public int HabilidadeTipoId { get; set; }
        public Habilidade Habilidade { get; set; }
    }
}