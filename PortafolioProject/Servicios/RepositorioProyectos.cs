using PortafolioProject.Models;

namespace PortafolioProject.Servicios
{
    public interface IRepositorioProyectos
    {
        List<ProyectoDTO> ObtenerProyecto();
    }
    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<ProyectoDTO> ObtenerProyecto()
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
                    ImagenURL = "/images/reddit.png"
                    },
                new ProyectoDTO
                {
                    Titulo = "Steam",
                    Descripcion = "Pagina para ver y subir videos",
                    Link = "https://amazon.com",
                    ImagenURL = "/images/steam.png"
                }
            };
        }


    }
}
