using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private MovieInfoContext daContext { get; set; }

        public HomeController(MovieInfoContext x)
        {
            daContext = x;
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
            ViewBag.Categories = daContext.Categories.ToList();

            return View("movieForm", new MovieForm());
        }


        //post the movie form page
        [HttpPost]
        public IActionResult MovieForm(MovieForm response)
        {
            if (ModelState.IsValid)
            {
                daContext.Add(response);
                daContext.SaveChanges();
                //return View("Conformation");
                return RedirectToAction("MovieList");

            }
            else
            {
                ViewBag.Categories = daContext.Categories.ToList();
                return View(response);
            }


            //I wasnt sure if I should return them back to the form if there are errors are not, so right now it does.
            //however there is alos a confermation page available
        }

        [HttpGet]
        public IActionResult MovieList()
        {
            var applications = daContext.responses
                .Include(x => x.Category)
                .ToList();

            return View(applications);
        }

        //get the edit movie page
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = daContext.Categories.ToList();

            var movie = daContext.responses.Single(x => x.ApplicationId == id);

            return View("MovieForm", movie);
        }

        //submit edits to a movie
        [HttpPost]
        public IActionResult Edit(MovieForm response)
        {
            if (ModelState.IsValid)
            {
                daContext.Update(response);
                daContext.SaveChanges();
            }
            else
            {
                ViewBag.Categories = daContext.Categories.ToList();
                return View("MovieForm", response);
            }

            return RedirectToAction("MovieList");
        }

        //get the delete page for a movie
        [HttpGet]
        public IActionResult Delete( int id)
        {
            var movie = daContext.responses.Single(x => x.ApplicationId == id);
            return View(movie);
        }

        //submit a delete for a movie
        [HttpPost]
        public IActionResult Delete(MovieForm response)
        {
            daContext.responses.Remove(response);
            daContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
