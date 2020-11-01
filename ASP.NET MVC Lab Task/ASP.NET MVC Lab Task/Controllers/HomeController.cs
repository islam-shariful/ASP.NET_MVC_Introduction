using ASP.NET_MVC_Lab_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Lab_Task.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        // POST: Home
        [HttpPost]
        public ActionResult Index(Person p)
        {
            TempData["person"] = p; 

            return RedirectToAction("Display");
        }
        // GET: Display
        [HttpGet]
        public ActionResult Display()
        {
            Person p = TempData["person"] as Person;
            return View(p);
        }
    }
}