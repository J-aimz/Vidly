using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Random()
        {
            Movie movie = new Movie()
            {
                Name = "Avatar"
            };

            return View(movie);
        }

        public IActionResult Edit(int  movieId)
        {
            return Content("id : " +  movieId);
        }
    }
}
