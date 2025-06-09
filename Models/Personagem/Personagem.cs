namespace Chronica.Models
{
    public class Personagem
    {
        public int Id { get; set; }
        public string NomePersonagem { get; set; }
        public string Jogador { get; set; }
        public int Idade { get; set; }

        public int? ClasseId { get; set; }
        public Classe Classe { get; set; }

        public int? ClaOuFamiliaId { get; set; }
        public ClaOuFamilia ClaOuFamilia { get; set; }

        public int? VarianteRacialId { get; set; }
        public VarianteRacial VarianteRacial { get; set; }


        // Coleções para relacionamentos muitos-para-muitos
        // Elas serão vinculadas às tabelas de junção
        public ICollection<PersonagemHabilidade> PersonagemHabilidades { get; set; } = new List<PersonagemHabilidade>();
        public ICollection<PersonagemSubHabilidade> PersonagemSubHabilidades { get; set; } = new List<PersonagemSubHabilidade>();
        public ICollection<PersonagemItem> PersonagemItens { get; set; } = new List<PersonagemItem>();
        public ICollection<PersonagemPericia> PersonagemPericias { get; set; } = new List<PersonagemPericia>();
    }
}