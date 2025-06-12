using System.ComponentModel.DataAnnotations.Schema;

namespace Chronica.Models.Universe
{
    public class ItemTipo
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [Column(TypeName = "TEXT")]
        public string Descricao { get; set; }

        // Chave estrangeira para o Usuário que criou/é dono deste item
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public ICollection<Item> Itens { get; set; } = new List<Item>();
    }
}