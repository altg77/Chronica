namespace Chronica.Models
{
    public class PersonagemItem
    {
        public int PersonagemId { get; set; }
        public Personagem Personagem { get; set; }

        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int Quantidade { get; set; } = 1;
    }
}