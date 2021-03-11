using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [HttpGet]
        public ActionResult GetUserProfile()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PostUserProfile(int id)
        {
            return View();
        }
        [HttpPut]
        public ActionResult PutOrUpdateUserProfile(int id ,Employee emp)
        {
            return View();
        }

        [HttpDelete]
        public ActionResult DeleteUserProfile(int id)
        {
            return View();
        }
    }
}