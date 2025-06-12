using System.ComponentModel.DataAnnotations.Schema;

namespace Chronica.Models
{
    public class AmeacasModel : Personagem
    {
        public string TipoAmeaca { get; set; } // (e.g., "Monstro", "Vilão", "Armadilha")
        
        public List<string> Vulnerabilidades { get; set;}

        public List<string> Imunidade { get; set; }

        public List<string> Resistencia{ get; set; }


        //Status

        [Column(TypeName = "TEXT")] 
        public string Descricao { get; set; }
    }
}