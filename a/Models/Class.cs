using Microsoft.VisualBasic;

namespace a.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string rut { get; set; }
        public DateTime Nacimiento { get; set; }
        public float Peso { get; set; }
        public string correo { get; set; }
        public bool alergias { get; set; }
        public string TipoSangre { get; set; }
        public bool Prevision { get; set; } 

    }
}
