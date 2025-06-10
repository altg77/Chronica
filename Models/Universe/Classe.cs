namespace Chronica.Models
{
    public class Classe
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string ImagemURL { get; set; }
        public ICollection<Personagem> Personagens { get; set; } = new List<Personagem>(); // Changed from Agentes to Personagens
    }
}