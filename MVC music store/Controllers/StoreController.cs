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