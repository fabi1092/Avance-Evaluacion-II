using Microsoft.VisualBasic;

namespace a.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Rut { get; set; }
        public DateTime Nacimiento { get; set; }
        public float Peso { get; set; }
        public string Correo { get; set; }
        public bool Alergias { get; set; }
        public string TipoSangre { get; set; }
        public bool Prevision { get; set; }

        // Constructor
        public Paciente(int id, string nombre, string rut, DateTime nacimiento, float peso, string correo, bool alergias, string tipoSangre, bool prevision)
        {
            Id = id;
            Nombre = nombre;
            Rut = rut;
            Nacimiento = nacimiento;
            Peso = peso;
            Correo = correo;
            Alergias = alergias;
            TipoSangre = tipoSangre;
            Prevision = prevision;
        }
    }

}
