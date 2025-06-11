namespace Chronica.Models
{
    public class PersonagemTipoHabilidade
    {
        public int PersonagemId { get; set; }
        public Personagem Personagem { get; set; }

        public int HabilidadeTipoId { get; set; }
        public HabilidadeTipo HabilidadeTipo { get; set; }
    }
}