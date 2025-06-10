namespace Chronica.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public string ImagemURL { get; set; }

        public ICollection<PersonagemItem> PersonagemItens { get; set; } = new List<PersonagemItem>(); // Changed to PersonagemItem
    }
}