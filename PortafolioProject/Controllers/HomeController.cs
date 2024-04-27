using Microsoft.AspNetCore.Mvc;
using PortafolioProject.Models;
using System.Diagnostics;

namespace PortafolioProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        private List<ProyectoDTO> ObtenerProyecto()
        {
            return new List<ProyectoDTO>() { 
                new ProyectoDTO 
                {
                    Titulo = "Amazon",
                    Descripcion = "E-Commerce realizado en ASP.NET Core",
                    Link = "https://amazon.com",
                    ImagenURL = "/images/amazon.png"
                    },
                new ProyectoDTO
                {
                    Titulo = "New York Times",
                    Descripcion = "Pagina web de noticias",
                    Link = "https://amazon.com",
                    ImagenURL = "/images/nyt.png"
                    },
                new ProyectoDTO
                { 
                    Titulo = "Reddit",
                    Descripcion = "Paginas de Noticias",
                    Link = "https://amazon.com",
                    ImagenURL = "reddit.png"
                    },
                new ProyectoDTO
                {
                    Titulo = "Steam",
                    Descripcion = "Pagina para ver y subir videos",
                    Link = "https://amazon.com",
                    ImagenURL = "steam.png"
                }
            };
        }


        public IActionResult Privacy()
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
