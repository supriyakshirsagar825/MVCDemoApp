using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult part11()
        {
            return View();
        }
        public ActionResult Index1()
        {
            ViewBag.Message = "my first index page viewbag message";
            return View();
        }
        public string Index()
        {
            return "first return from index mentod";//View();
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
    }
}