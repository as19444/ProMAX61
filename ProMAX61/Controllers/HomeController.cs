using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShortBooking.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Host()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AptDetails()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}