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
        public ActionResult VBVD()
        {
            ViewBag.Message = "View Bag Example";
            ViewBag.MyList = new List<string> { "supriya", "pankaj", "shreddha", "seema" };
            List<Employee> emp = new List<Employee>()
            {
                new Employee(){id=1,name="abc",address="abc address",salary=100000},
                new Employee(){id=2,name="xyz",address="xyz address",salary=200000},
                new Employee(){id=3,name="pqr",address="pqr address",salary=300000},

            };
            ViewBag.EmpList = emp;

            List<Employee> emp1 = new List<Employee>()
            {
                new Employee(){id=11,name="abc1",address="abc1 address",salary=100000},
                new Employee(){id=21,name="xyz1",address="xyz1 address",salary=200000},
                new Employee(){id=31,name="pqr1",address="pqr1 address",salary=300000},

            };
          
            ViewData["Message1"] = "View Data Example1";
            ViewData["MyList1"] = new List<string> { "supriya1", "pankaj1", "shreddha1", "seema1" };
            ViewData["EmpList1"] = emp1;

            return View();
        }
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
        public ActionResult Index()
        {
           // return "first return from index mentod";
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
    }
}