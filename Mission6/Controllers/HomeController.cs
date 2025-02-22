using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();
            return View();
        }
        [HttpPost]
        public IActionResult EnterMovies(Movie response)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();
            return View("Confirmation", response);
        }

        public IActionResult ViewMovies()
        {
            
            var movies = _context.Movies
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();

            return View(movies);
        }

        public IActionResult Edit(int id)
        {
            var record = _context.Movies
                .Where(x => x.MovieID == id);
            
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();
            

            return View("EnterMovie");
        }

    }


}
