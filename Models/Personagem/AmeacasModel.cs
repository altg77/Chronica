namespace Chronica.Models
{
    public class AmeacasModel: Personagem
    { 
        public string NivelDificuldade { get; set; } // Specific to Threats (e.g., "Fácil", "Médio", "Boss")
        public string TipoAmeaca { get; set; } // (e.g., "Monstro", "Vilão", "Armadilha")
    }
}