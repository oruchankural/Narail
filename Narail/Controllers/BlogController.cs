using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Narail.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            ViewBag.Title = "Narali | Blog ";
            return View();
        }
        public ActionResult Categories()
        {
            return View();
        }
        public ActionResult Mostviewed()
        {
            return View();
        }
        public ActionResult Tags()
        {
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
    }
}