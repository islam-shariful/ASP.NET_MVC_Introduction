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
        public ActionResult Display()
        {
            string name = Request["name"];
            string userName = Request["userName"];
            string bloodGroup = Request["bloodGroup"];
            string gender = Request["gender"];

            Session["name"] = name;
            ViewData["userName"] = userName;
            ViewBag.bloodGroup = bloodGroup;
            TempData["gender"] = gender;

            Person p = new Person()
            {
                Name = Request["name"],
                UserName = Request["userName"],
                Password = Request["password"],
                ConfirmPassword = Request["confirmPassword"],
                BloodGroup = Request["bloodGroup"],
                Gender = Request["gender"],
                DateOfBirth = Request["dateOfBirth"],
            };
            return View("Display",p);
        }
        public String anotherTest(int? id =null)
        {
            return "This is another method " + id.ToString();
            //return View();
        }
    }
}