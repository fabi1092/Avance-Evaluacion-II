using Microsoft.AspNetCore.Mvc;
using a.Models; 
using System;
using System.Collections.Generic;

namespace a.Controllers
{
    public class PacienteController : Controller
    {
        public IActionResult Index()
        {
            Paciente paciente1 = new Paciente(
                 id: 1,
                 nombre: "Juan Pérez",
                 rut: "12.345.678-9",
                 nacimiento: new DateTime(1990, 5, 20),
                 peso: 72.5f,
                 correo: "juan.perez@example.com",
                 alergias: true,
                 tipoSangre: "O+",
                 prevision: true
             );

            return View(pacientes);
        }
    }
}