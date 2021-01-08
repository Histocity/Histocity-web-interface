using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Histocity_Website.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult List()
        {
            if (HttpContext.Session.GetString("userID") == null)
            {
                ViewBag.IsLoggedIn = false;
                return RedirectToAction("Login", "User");
            }
            else
            {
                ViewBag.IsLoggedIn = true;
                ViewBag.TeacherID = HttpContext.Session.GetString("userID");
                return View();
            }
            
        }

        [HttpGet]
        public ActionResult Add(string teacherID)
        {
            return View();
        }
    }
}
