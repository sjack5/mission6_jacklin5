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
        private readonly ILogger<HomeController> _logger;
        private MoviesContext _moviesContext { get; set; }

        //Contructor
        public HomeController(ILogger<HomeController> logger, MoviesContext someName)
        {
            _logger = logger;
            _moviesContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(MovieForm mf)
        {
            _moviesContext.Add(mf);
            _moviesContext.SaveChanges();

            return View("Confirmation", mf);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
