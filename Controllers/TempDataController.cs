using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class TempDataController : Controller
    {
        // GET: TempData
        public ActionResult Index()
        {
            TempData["mytempdata"] = "This is Value from temp data";
            return View();
        }
        public ActionResult Index1()
        {
            ViewBag.mytestdata = TempData.Peek("mytempdata") + "from index1";

            //TempData.Keep("mytempdata");
            
            return View();
        }
        public ActionResult Index2()
        {
            ViewBag.mytestdata = TempData["mytempdata"]+"some addation index2";
            return View();
        }
    }
}