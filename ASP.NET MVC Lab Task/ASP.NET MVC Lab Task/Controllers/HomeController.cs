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
        public ActionResult Display(Person pc)
        {
            Person p = new Person()
            {
                Name = pc.Name,
                UserName = pc.UserName,
                Password = pc.Password,
                ConfirmPassword = pc.ConfirmPassword,
                BloodGroup = pc.BloodGroup,
                Gender = pc.Gender,
                DateOfBirth = pc.DateOfBirth,
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