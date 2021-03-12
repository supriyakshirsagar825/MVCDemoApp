using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PostPersonDetails(Person p)
        {
            if(ModelState.IsValid)
            {
                return View(p);
            }
            return View("Index");
        }

        [HttpGet]
        public ActionResult GetPesronDetailsForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult persondetailswithstronlybinding(Person p)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                return View(p);
            }
            return View("GetPesronDetailsForm");
        }


    }
}