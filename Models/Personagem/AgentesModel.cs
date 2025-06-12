using System.ComponentModel.DataAnnotations.Schema;

namespace Chronica.Models
{
    public class AgentesModel : Personagem
    {

        // Propriedades de Descricao

        [Column(TypeName = "TEXT")]
        public string Aparencia { get; set; }

        [Column(TypeName = "TEXT")]
        public string Objetivos { get; set; }

        [Column(TypeName = "TEXT")]
        public string Historia { get; set; }

        [Column(TypeName = "TEXT")]
        public string Personalidade { get; set; }
        
        public string Caractere { get; set; }
    }
}