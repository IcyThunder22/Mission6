using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6.Models;

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {
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
            return View("EnterMovies");
        }
        [HttpPost]
        public IActionResult EnterMovies(Movie response)
        {
            return View("Confirmation", response);
        }
    }
}
