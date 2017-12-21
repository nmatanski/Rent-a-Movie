using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoviesForRent.Models;

namespace MoviesForRent.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };

            //return View(movie); // !!!
            //return new RedirectResult("https://www.google.com/"); // !!!
            //return HttpNotFound(); // !!!
            //return Content("Hello World");
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"});

            return View(movie);
        }
    }
}