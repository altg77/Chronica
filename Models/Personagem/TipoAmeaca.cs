using System.ComponentModel.DataAnnotations.Schema;

namespace Chronica.Models
{
    public class TipoAmeaca
    {
        public int Id { get; set; }
        public string Nome { get; set; } // Ex: "Criatura", "Organização", "Fenômeno"

        [Column(TypeName = "TEXT")]
        public string Descricao { get; set; }


        // Chave estrangeira para o Usuário que criou/é dono deste Tipo de Ameaça
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }


        // Coleção de Ameaças que pertencem a este tipo
        public ICollection<AmeacasModel> Ameacas { get; set; } = new List<AmeacasModel>();
    }
}