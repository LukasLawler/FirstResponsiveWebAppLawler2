using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstResponsiveWebAppLawler.Models;

namespace FirstResponsiveWebAppLawler.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Age = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person person, string dummy)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Age = person.AgeThisYear();
            }
            else
            {
                ViewBag.Age = 0;
            }
            return View(person);
        }
    }
}
