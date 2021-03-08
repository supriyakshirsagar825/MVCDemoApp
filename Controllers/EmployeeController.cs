using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            var data = GetEmployeeFromController();
            return View("~/Views/myview/Mytestview.cshtml", data);
        }

        public Employee GetEmployeeFromController()
        {
            return new Employee()
            {
                id = 1,
                name = "supriya",
                salary = 100000,
                address = "1200 center g l"
            };
        }
    }
}