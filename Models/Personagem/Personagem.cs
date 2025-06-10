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
        

        // Propriedades de Descricao

        [Column(TypeName = "TEXT")]
        public string Aparencia { get; set; }

        [Column(TypeName = "TEXT")]
        public string Objetivos { get; set; }

        [Column(TypeName = "TEXT")]
        public string Historia { get; set; }

        [Column(TypeName = "TEXT")]
        public string Personalidade { get; set; }


        //Atributos Principais
        public int Forca { get; set; }
        public int Agilidade { get; set; }
        public int Constituicao { get; set; }
        public int Espirito { get; set; }
        public int Intelecto { get; set; }
        public int Carisma { get; set; }

        public int PontosAtributo { get; set; } = 5; // Quantidade de pontos disponíveis para distribuir


        // Subatributos Calculados
        public int VidaMaxima => Constituicao * 10; // Exemplo de cálculo, ajuste conforme necessário
        public int Vida { get; set; } // Vida atual do personagem


        // Atributo Dinâmico baseado em Espirito
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
        public ICollection<PersonagemHabilidade> PersonagemHabilidades { get; set; } = new List<PersonagemHabilidade>();
        public ICollection<PersonagemSubHabilidade> PersonagemSubHabilidades { get; set; } = new List<PersonagemSubHabilidade>();
        public ICollection<PersonagemItem> PersonagemItens { get; set; } = new List<PersonagemItem>();
        public ICollection<PersonagemPericia> PersonagemPericias { get; set; } = new List<PersonagemPericia>();
    }
}