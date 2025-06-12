namespace Chronica.Models
{
    public class UsuarioCampanha
    {
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public int CampanhaId { get; set; }
        public Campanha Campanha { get; set; }
    }
}