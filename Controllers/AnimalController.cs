using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class AnimalController : Controller
    {
        // GET: Animal
        public ActionResult Index()
        {
            return View("Index", "_LayoutWithSection");
        }
        [HttpPost]
        public ActionResult Index1(string txtName)
        {
            ViewBag.Name = txtName;
            return View("Index", "_LayoutWithSection");
        }


        public ActionResult PageFirst()
        {
            return View();
        }
        public ActionResult PageSecond()
        {
            return View();
        }
    }
}