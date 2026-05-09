using Microsoft.AspNetCore.Mvc;

namespace a.Controllers
{
    public class HomeController1 : Controller
    { }

namespace a.Controllers
    {
        public class ProductosController : Controller
        {
            public IActionResult Index()
            {
                var productos = new List<dynamic>
            {
                new { Id = 1, Nombre = "Mouse", Precio = 10000 },
                new { Id = 2, Nombre = "Teclado", Precio = 20000 },
                new { Id = 3, Nombre = "Monitor", Precio = 150000 }
            };

                return View(productos);
            }
        }
    }
}