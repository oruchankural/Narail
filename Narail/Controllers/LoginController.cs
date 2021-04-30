using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Narail.Models;

namespace Narail.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        NarailDBEntities db = new NarailDBEntities();
        public ActionResult Index()
        {
            var model = db.Author.ToList();
            return View();
        }
    }
}