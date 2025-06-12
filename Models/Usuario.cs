using Chronica.Models.Universe;

namespace Chronica.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string Email { get; set; }
        public string SenhaHash { get; set; }
        public string Patente { get; set; }
        public string ImagemURL { get; set; }


        // Coleções de elementos que este usuário POSSUI (criou)
        public ICollection<Campanha> CampanhasCriadas { get; set; } = new List<Campanha>();
        
        public ICollection<Personagem> PersonagensCriados { get; set; } = new List<Personagem>(); 
        public ICollection<TipoAmeaca> TiposAmeacaCriados { get; set; } = new List<TipoAmeaca>();

        public ICollection<Item> ItensCriados { get; set; } = new List<Item>();
        public ICollection<Habilidade> HabilidadesCriadas { get; set; } = new List<Habilidade>();
        public ICollection<HabilidadeTipo> HabilidadeTiposCriados { get; set; } = new List<HabilidadeTipo>();
        public ICollection<ItemTipo> ItemTiposCriados { get; set; } = new List<ItemTipo>();
        public ICollection<Pericia> PericiaTiposCriados { get; set; } = new List<Pericia>();
        public ICollection<Vantagens> VantagensCriadas { get; set; } = new List<Vantagens>();
        public ICollection<Desvantagens> DesvantagensCriadas { get; set; } = new List<Desvantagens>();
        public ICollection<Origem> OrigensCriadas { get; set; } = new List<Origem>();
        public ICollection<Classe> ClassesCriadas { get; set; } = new List<Classe>();
        public ICollection<VarianteRacial> VariantesRaciaisCriadas { get; set; } = new List<VarianteRacial>();



        // Coleção de campanhas que o usuário PARTICIPA (para o relacionamento muitos-para-muitos)
        public ICollection<UsuarioCampanha> UsuarioCampanhas { get; set; } = new List<UsuarioCampanha>();
    }
}