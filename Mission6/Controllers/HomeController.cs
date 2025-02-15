using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6.Models;

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {
        private MovieDbContext _context;
        public HomeController(MovieDbContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EnterMovies()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EnterMovies(Movie response)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();
            return View("Confirmation", response);
        }
    }
}
