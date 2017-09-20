using MVC_music_store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_music_store.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            // mock up some album data and pass to the view
            var genres = new List<Genre>();
            for (int i = 0; i<= 10; i++)
            {
                genres.Add(new Genre { Name = "Genre" + i });
            }


            ViewBag.genres = genres;
            ViewBag.Message = "please select a Genre";
            return View();
        }
        // GET: Store/Browse
        public ActionResult Browse(string genre)
        {
            // Send Genre back to the view
            ViewBag.Genre = genre;
            return View();
        }
    }
}