namespace Chronica.Models
{
    public class PersonagemCampanha
    {
        public int PersonagemId { get; set; }
        public Personagem Personagem { get; set; }

        public int CampanhaId { get; set; }
        public Campanha Campanha { get; set; }
    }
}