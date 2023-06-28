using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        //Get: Movies/Random
        public IActionResult Random()
        {
            Movie movie = new Movie()
            {
                Name = "Avatar"
            };

            return View(movie);
        }

        //Get: Movies/Edit/Id=1
        public IActionResult Edit(int  id)
        {
            return Content("id : " +  id);
        }

        //Get: Movies 
        public IActionResult Index()
        {
           return View();

        }

        //using custom routing (Attribute routing)
        [Route("movies/released/{{year}}/{{month:regex(\\d{2}):range(1,12)}}")]
        public IActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }



    }
}
