using System.ComponentModel.DataAnnotations.Schema;

namespace Chronica.Models.Universe
{
    public class ItemTipo
    {
        public int Id { get; set; }
        public string Nome { get; set; }

         [Column(TypeName = "TEXT")] 
        public string Descricao { get; set; }

        public ICollection<Item> Itens { get; set; } = new List<Item>();
    }
}