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
            return View("Index");
        }
        [HttpPost]
        public ActionResult Display(FormCollection fc, string name)
        {
            Person p = new Person()
            {
                Name = name,
                UserName = fc["userName"],
                Password = fc["password"],
                ConfirmPassword = fc["confirmPassword"],
                BloodGroup = fc["bloodGroup"],
                Gender = fc["gender"],
                DateOfBirth = fc["dateOfBirth"],
            };
            return View(p);
        }
        public String anotherTest(int? id =null)
        {
            return "This is another method " + id.ToString();
            //return View();
        }
    }
}