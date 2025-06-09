namespace Chronica.Models
{
    public class PersonagemPericia
    {
        public int PersonagemId { get; set; }
        public Personagem Personagem { get; set; }

        public int PericiaId { get; set; }
        public Pericia Pericia { get; set; }
        public string Nivel { get; set; } // Store the character's proficiency level for this specific skill
    }
}