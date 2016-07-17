
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Sultan!" };
            return View(movie);
            
        }
        public ActionResult edit(int id)
        {

            return Content("id" + id);
        }
        public ActionResult Index(int? pageindex, string sortby)
        {
            if (!pageindex.HasValue)
                pageindex = 1;
            if (String.IsNullOrWhiteSpace(sortby))
                sortby = "Name";
            return Content(String.Format("pageindex={0}&sortby={1}",pageindex, sortby));
        }
    }
}