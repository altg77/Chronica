using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Chronica.Models
{
    public class Habilidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [Column(TypeName = "TEXT")] // For potentially long descriptions
        public string Descricao { get; set; }
        public string ImagemURL { get; set; }


        // Chave estrangeira para o Usuário que criou/é dono deste item
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public int HabilidadeTipoId { get; set; }
        public HabilidadeTipo HabilidadeTipo { get; set; }
        
        public ICollection<PersonagemHabilidade> PersonagemHabilidades { get; set; } = new List<PersonagemHabilidade>();
    }
}