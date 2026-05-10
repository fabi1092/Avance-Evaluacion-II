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
           
            var pacientes = new List<Paciente>
            {
                new Paciente { Id = 1, Nombre = "Juan Pérez", rut = "11111111-1", Nacimiento = new DateTime(1990, 5, 12), Peso = 75.5f, correo = "juan@mail.com", alergias = false, TipoSangre = "O+", Prevision = true },
                new Paciente { Id = 2, Nombre = "María López", rut = "22222222-2", Nacimiento = new DateTime(1985, 8, 22), Peso = 62.0f, correo = "maria@mail.com", alergias = true, TipoSangre = "A+", Prevision = true },
                new Paciente { Id = 3, Nombre = "Pedro Sánchez", rut = "33333333-3", Nacimiento = new DateTime(2000, 1, 15), Peso = 80.2f, correo = "pedro@mail.com", alergias = false, TipoSangre = "B-", Prevision = false },
                new Paciente { Id = 4, Nombre = "Ana Gómez", rut = "44444444-4", Nacimiento = new DateTime(1995, 11, 30), Peso = 55.4f, correo = "ana@mail.com", alergias = true, TipoSangre = "AB+", Prevision = true },
                new Paciente { Id = 5, Nombre = "Luis Torres", rut = "55555555-5", Nacimiento = new DateTime(1988, 3, 5), Peso = 90.1f, correo = "luis@mail.com", alergias = false, TipoSangre = "O-", Prevision = false },
                new Paciente { Id = 6, Nombre = "Carmen Ruiz", rut = "66666666-6", Nacimiento = new DateTime(1975, 7, 18), Peso = 68.9f, correo = "carmen@mail.com", alergias = false, TipoSangre = "A-", Prevision = true },
                new Paciente { Id = 7, Nombre = "Jorge Díaz", rut = "77777777-7", Nacimiento = new DateTime(1992, 9, 25), Peso = 77.3f, correo = "jorge@mail.com", alergias = true, TipoSangre = "O+", Prevision = true },
                new Paciente { Id = 8, Nombre = "Elena Castro", rut = "88888888-8", Nacimiento = new DateTime(2002, 4, 10), Peso = 60.5f, correo = "elena@mail.com", alergias = false, TipoSangre = "B+", Prevision = false },
                new Paciente { Id = 9, Nombre = "Diego Mora", rut = "99999999-9", Nacimiento = new DateTime(1980, 12, 5), Peso = 85.0f, correo = "diego@mail.com", alergias = true, TipoSangre = "A+", Prevision = true },
                new Paciente { Id = 10, Nombre = "Sofía Vega", rut = "10101010-0", Nacimiento = new DateTime(1998, 2, 20), Peso = 58.7f, correo = "sofia@mail.com", alergias = false, TipoSangre = "O+", Prevision = true }
            };

            return View(pacientes);
        }
    }
}