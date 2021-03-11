using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

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
        public ActionResult GetAllStudent()
        {
            var student = GetStudents();
            return View(student);
        }
        public ActionResult GetStudentById(int id)
        {
            var student = GetStudents().FirstOrDefault(d => d.StudentId == id);
            return View(student);
        }
        public ActionResult GetStudentAddress(int id)
        {
            var StudentAddress = GetStudents().Where(d => d.StudentId == id).Select(x => x.StudentAddress).FirstOrDefault();
            return View(StudentAddress);
        }
        public List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student(){ StudentId=1, StudentName="supriya",Email="sup@gmail.com",
                    StudentAddress=new Address(){ AddressLine1="12303 center lane", City="louisville" , State="KY",ZipCode=40223 } },
                new Student(){ StudentId=2, StudentName="pankaj",Email="pankaj@gmail.com",
                    StudentAddress=new Address(){ AddressLine1="1919 carlsbad  center ", City="naperville" , State="IL",ZipCode=60563 } },
            };
        }

        public string StudentAddress(int id, string stradd = "supriyaadd")
        {
            return id + " " + stradd;
        }
        public ActionResult StudentAbout(int id)
        {
            if (id == 1)
                ViewBag.StudentAboutPage = "This is StudentAboutPage " + id + "supriya";
            else
            {
                ViewBag.StudentAboutPage = "This is StudentAboutPage " + id + "pankaj";
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