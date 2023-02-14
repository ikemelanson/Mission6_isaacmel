using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6_isaacmel.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_isaacmel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieInfoContext blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieInfoContext x)
        {
            _logger = logger;
            blahContext = x;
        }

        public IActionResult Index()
        {
            //hompage
            return View();
        }

        //get the movie form page
        [HttpGet]
        public IActionResult MovieForm()
        {
            return View("movieForm");
        }


        //post the movie form page
        [HttpPost]
        public IActionResult MovieForm(MovieForm response)
        {
            blahContext.Add(response);
            blahContext.SaveChanges();
            //return View("Conformation");
            return View("movieForm");

            //I wasnt sure if I should return them back to the form if there are errors are not, so right now it does.
            //however there is alos a confermation page available
        }

        public IActionResult podcasts()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
