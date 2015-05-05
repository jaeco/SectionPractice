using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SectionPractice.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string layoutname)
        {
            ViewBag.layoutname = (layoutname == null) ? "" : layoutname;
            return View();
        }
    }
}