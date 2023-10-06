using Microsoft.AspNetCore.Mvc;
using ASD.Models;
namespace ASD.Controllers
{
    public class MovieController : Controller
    {
        public ViewResult Random()
        {
            var movie = GetMovie();
                return View(movie);
        }
        public ActionResult Details(int id) 
        {
            var movie =GetMovie().SingleOrDefault(c=> c.Id == id);
            if (movie == null)
                return View();
            return View(movie); 
        }
        private IEnumerable<Movie> GetMovie() 
        {
            return new List<Movie>
            { new Movie{Id= 1, Name = "mov1" },
            new Movie {Id= 2, Name= "mov2" }
            };
        }
    }
}
