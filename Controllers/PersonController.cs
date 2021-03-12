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
        public ActionResult GetPersonDetails(Person p)
        {
            if(ModelState.IsValid)
            {
                return View("GetPersonDetails",p);
            }
            return View("Index");
        }
    }
}