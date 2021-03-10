using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult part11()
        {
            
            return View();
        }
        public ActionResult part12()
        {
            EmployeeModel emp = new EmployeeModel()
            {
                Id = 1,
                Name = "supriya",
                Address = "12302centr grove ln",
                IsEmployee = true,
                Salary = 12202


            };
            return View(emp);
        }
        [HttpPost]
        public ActionResult Part12PostMethod(EmployeeModel emp)
        {
            return View(emp);
        }

        public ActionResult part13()
        {
            EmployeeModel emp = new EmployeeModel()
            {
                Id = 2,
                Name = "pankaj",
                Address = "1919 carls bad circle grove ln",
                IsEmployee = true,
                Salary = 7000000,
                DOB = DateTime.Now,
                Email = "panakj@gmail.com",
                IsOnline = true,
            };

            return View(emp);
        }

        public ActionResult part13part1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {
            return View(emp);
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