using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mission6_jacklin5.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mission6_jacklin5.Controllers
{
    public class HomeController : Controller
    {
        private MoviesContext moviesContext { get; set; }

        //Contructor
        public HomeController(ILogger<HomeController> logger, MoviesContext someName)
        {
            moviesContext = someName;
        }

        //Returns index page
        public IActionResult Index()
        {
            return View();
        }

        //Returns podcast page
        public IActionResult MyPodcasts()
        {
            return View();
        }

        //Opens new movie form
        [HttpGet]
        public IActionResult AddMovie()
        {
            ViewBag.Category = moviesContext.Categories.ToList();

            return View(new MovieForm());   //Added new MovieForm because of empty primary key error
                                            //from fixing the edit functionality
        }

        //Adds movie to database
        [HttpPost]
        public IActionResult AddMovie(MovieForm mf)
        {
            if (ModelState.IsValid)             //This validates our form so no incorrect datatypes can
            {                                   //be put in
                moviesContext.Add(mf);
                moviesContext.SaveChanges();

                var collection = moviesContext.Movie.ToList();
                return View("Collection", collection);
            }
            else
            {
                ViewBag.Category = moviesContext.Categories.ToList();

                return View(mf);
            }
        }

        //Lists all movies in our collection
        public IActionResult Collection()
        {
            var collection = moviesContext.Movie.ToList();
            return View(collection);
        }

        //Grabs single value for our database and allows us to edit it
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Category = moviesContext.Categories.ToList();
            var movie_edit = moviesContext.Movie.Single(x => x.MovieID == id);
            
            return View("AddMovie", movie_edit);
        }

        //Takes changes from edit and adds that to database
        [HttpPost]
        public IActionResult Edit(MovieForm movie_edit)
        {
            moviesContext.Update(movie_edit);
            moviesContext.SaveChanges();

            return RedirectToAction("Collection");
        }

        //Removes record from our table
        [HttpGet]
        public IActionResult Delete (int id)
        {
            var movie_delete = moviesContext.Movie.Single(x => x.MovieID == id);
            moviesContext.Movie.Remove(movie_delete);
            moviesContext.SaveChanges();

            return RedirectToAction("Collection");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
