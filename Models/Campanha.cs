using System.ComponentModel.DataAnnotations.Schema;

namespace Chronica.Models
{
    public class Campanha
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string ImagemURL { get; set; }

        [Column(TypeName = "TEXT")]
        public string Descricao { get; set; }


        // Chave estrangeira para o Usuário que criou/é dono desta campanha
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } // Usuário dono da campanha


        // Coleção de Personagens (Agentes/Ameaças) que fazem parte desta campanha
        public ICollection<PersonagemCampanha> PersonagemCampanhas { get; set; } = new List<PersonagemCampanha>();
        

        // Coleção para o relacionamento Muitos-para-Muitos com Usuario (quem participa da campanha)
        public ICollection<UsuarioCampanha> UsuarioCampanhas { get; set; } = new List<UsuarioCampanha>();

    }
}