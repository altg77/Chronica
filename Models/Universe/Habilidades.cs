namespace Chronica.Models
{
    public class Habilidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public ICollection<SubHabilidade> SubHabilidades { get; set; } = new List<SubHabilidade>();
        public ICollection<PersonagemHabilidade> PersonagemHabilidades { get; set; } = new List<PersonagemHabilidade>(); // Changed to PersonagemHabilidade
    }
}