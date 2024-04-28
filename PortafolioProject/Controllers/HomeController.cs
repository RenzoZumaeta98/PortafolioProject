using Microsoft.AspNetCore.Mvc;
using PortafolioProject.Models;
using PortafolioProject.Servicios;
using System.Diagnostics;

namespace PortafolioProject.Controllers
{
    public class HomeController : Controller
    {
        //INYECCION DE DEPENDENCIAS
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos repositorioProyectos;

        public HomeController(ILogger<HomeController> logger, IRepositorioProyectos repositorioProyectos)
        {
            _logger = logger;
            this.repositorioProyectos = repositorioProyectos;
        }

        public IActionResult Index()
        {
            var proyectos = repositorioProyectos.ObtenerProyecto().Take(3).ToList();
            var modelo = new HomeIndexDTO() { Proyectos = proyectos };
            return View(modelo);
        }


        public IActionResult Proyectos()
        {
            var proyectos = repositorioProyectos.ObtenerProyecto();

            return View(proyectos);
        }

        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contacto(ContactoDTO contactoDTO)
        {
            return RedirectToAction("Gracias");
        }

        public IActionResult Gracias()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
