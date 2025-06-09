namespace Chronica.Models
{
    public class Pericia
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public ICollection<PersonagemPericia> PersonagemPericias { get; set; } = new List<PersonagemPericia>(); // Changed to PersonagemPericia
    }
}