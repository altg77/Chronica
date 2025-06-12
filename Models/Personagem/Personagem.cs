using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chronica.Models
{
    public abstract class Personagem
    {
        public int Id { get; set; }
        public string ImagemURL { get; set; } 
        public string Nome { get; set; }
        public int Idade { get; set; }


        //Atributos Principais
        public int Forca { get; set; } // Força do personagem
        public int Agilidade { get; set; } // Velocidade do personagem
        public int Constituicao { get; set; } // Vida do personagem
        public int Espirito { get; set; } // Poder do personagem
        public int Intelecto { get; set; }  // Pericias do personagem
        public int Carisma { get; set; } // Pericias do personagem

        public int PontosAtributo { get; set; } = 5; // Quantidade de pontos disponíveis para distribuir


        // Subatributos Calculados
        public int VidaMaxima => Constituicao * 10; // Exemplo de cálculo, ajuste conforme necessário

        public int Vida { get; set; } // Vida atual do personagem
        public int Defesa { get; set; }
        public int Deslocamento { get; set; }


        // Atributo Dinâmico baseado em Espirito ( Respiracao, Kekijutsu, Energia Amaldiçoada, Chakra, Ki)
        [NotMapped]
        public Dictionary<string, int> AtributosDeEspirito { get; set; } = new Dictionary<string, int>();


        // Subatributos relacionados a Carisma
        public int Egoismo => Carisma / 2; // Exemplo de cálculo
        public int Persuasao => Carisma * 3; // Exemplo de cálculo


        // Foreign Keys para relacionamentos Um-para-Muitos
        public int? ClasseId { get; set; }
        public Classe Classe { get; set; }

        public int? OrigemId { get; set; }
        public Origem Origem { get; set; }

        public int? VarianteRacialId { get; set; }
        public VarianteRacial VarianteRacial { get; set; }


        // Coleções para relacionamentos muitos-para-muitos
        // Elas serão vinculadas às tabelas de junção
        public ICollection<PersonagemTipoHabilidade> PersonagemTipoHabilidades { get; set; } = new List<PersonagemTipoHabilidade>();
        public ICollection<PersonagemHabilidade> PersonagemHabilidades { get; set; } = new List<PersonagemHabilidade>();
        public ICollection<PersonagemItem> PersonagemItens { get; set; } = new List<PersonagemItem>();
        public ICollection<PersonagemPericia> PersonagemPericias { get; set; } = new List<PersonagemPericia>();
    }
}