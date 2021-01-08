using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Histocity_Website.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("userID") == null)
            {
                ViewBag.IsLoggedIn = false;
            } else
            {
                ViewBag.IsLoggedIn = true;
            }

            return View();
        }
    }
}
