using System.ComponentModel.DataAnnotations.Schema;

namespace Chronica.Models.Universe
{
    public class Vantagens
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        [Column(TypeName = "TEXT")] // For potentially long descriptions
        public string Descricao { get; set; }

    }
}