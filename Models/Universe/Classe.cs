using System.ComponentModel.DataAnnotations.Schema;

namespace Chronica.Models
{
    public class Classe
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [Column(TypeName = "TEXT")]
        public string Descricao { get; set; }
        public string ImagemURL { get; set; }

        // Chave estrangeira para o Usuário que criou/é dono deste item
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        
        public ICollection<Personagem> Personagens { get; set; } = new List<Personagem>(); // Changed from Agentes to Personagens
    }
}