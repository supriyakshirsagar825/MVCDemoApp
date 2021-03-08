using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.StrDiv = "put this message in student div";
            return View("~/Views/myview/Mytestview.cshtml");
        }
        public string StudentAddress(int id, string stradd = "supriyaadd")
        {
            return id + " " + stradd;
        }
        public ActionResult StudentAbout(int id)
        {
            if(id==1)
                ViewBag.StudentAboutPage = "This is StudentAboutPage " + id + "supriya";
            else
            {
                ViewBag.StudentAboutPage = "This is StudentAboutPage " + id+"pankaj";
            }

            return View();
        }

        public ActionResult StudentContactPage(string msg)
        {
            ViewBag.ContactStrmsg = "this is testing of contus page " + msg;
            return View();
        }


    }
}