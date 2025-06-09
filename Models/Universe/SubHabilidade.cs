namespace Chronica.Models
{
    public class SubHabilidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int HabilidadeTipoId { get; set; }
        public Habilidade Habilidade { get; set; }
        public ICollection<PersonagemSubHabilidade> PersonagemSubHabilidades { get; set; } = new List<PersonagemSubHabilidade>(); // Changed to PersonagemSubHabilidade
    }
}