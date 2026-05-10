using Microsoft.AspNetCore.Mvc;
using a.Models;

namespace a.Controllers
{
    public class PacientesController : Controller
    {
        public IActionResult Index()
        {
            var pacientes = new List<Paciente>
            {
                new Paciente { Id = 1, Nombre = "Juan Pérez", rut = "12.345.678-9", Peso = 70, correo = "juan@correo.com", TipoSangre = "O+", alergias = false, Prevision = true },
                new Paciente { Id = 2, Nombre = "María Soto", rut = "11.222.333-4", Peso = 62, correo = "maria@correo.com", TipoSangre = "A+", alergias = true, Prevision = true }
            };

            return View(pacientes);
        }
    }
}