using System.ComponentModel.DataAnnotations.Schema;

namespace Chronica.Models.Universe
{
    public class Desvantagens
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        [Column(TypeName = "TEXT")] // For potentially long descriptions
        public string Descricao { get; set; }

    }
}