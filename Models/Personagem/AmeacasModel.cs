using System.ComponentModel.DataAnnotations.Schema;

namespace Chronica.Models
{
    public class AmeacasModel : Personagem
    {

        // Chave estrangeira para o TipoAmeaca
        public int TipoAmeacaId { get; set; }
        public TipoAmeaca TipoAmeaca { get; set; }


        public List<string> Vulnerabilidades { get; set; }

        public List<string> Imunidade { get; set; }

        public List<string> Resistencia { get; set; }


        //Status

        [Column(TypeName = "TEXT")]
        public string Descricao { get; set; }
    }
}