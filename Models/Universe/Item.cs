using System.ComponentModel.DataAnnotations.Schema;
using Chronica.Models.Universe; // Para [Column(TypeName = "TEXT")]

namespace Chronica.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Nome { get; set; }  
        public string ImagemURL { get; set; }


        [Column(TypeName = "TEXT")]
        public string Descricao { get; set; }

        // Chave estrangeira para a CATEGORIA de item
        public int ItemTipoId { get; set; }
        public ItemTipo ItemTipo { get; set; }


        // Chave estrangeira para o Usuário que criou/é dono deste item
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }


        public ICollection<PersonagemItem> PersonagemItens { get; set; } = new List<PersonagemItem>(); // Changed to PersonagemItem
    }
}