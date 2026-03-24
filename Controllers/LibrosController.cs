using Microsoft.AspNetCore.Mvc;
using BibliotecaWeb.Models;

namespace BibliotecaWeb.Controllers
{
    public class LibrosController : Controller
    {
        private static List<Libro> libros = new List<Libro>
        {
            new Libro { Id = 1, Titulo = "Don Quijote", Autor = "Cervantes", Anio = 1605 },
            new Libro { Id = 2, Titulo = "1984", Autor = "George Orwell", Anio = 1949 }
        };

        public IActionResult Index()
        {
            return View(libros);
        }
    }
}