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
        public ActionResult Index   ()
        {
            //return RedirectToAction("AnotherTest");
            //return "Hello C#";
            if(Request.HttpMethod == "GET")
            {
                return View("Test");
            }
            else if(Request.HttpMethod == "POST")
            {
                string name = Request["name"];
                string userName = Request["userName"];
                string password = Request["password"];
                string confirmPassword = Request["confirmPassword"];
                string bloodGroup = Request["bloodGroup"];
                string gender = Request["gender"];
                string dateOfBirth= Request["dateOfBirth"];

                Session["name"] = name;
                ViewData["userName"] = userName;
                ViewBag.bloodGroup = bloodGroup;
                TempData["gender"] = gender;
                return View("Test");
                //return Content("<h1>Name is: " + name + "</h1>");
            }
            else
            {
                return Content("<h1>It doesn't work</h1>");
            }
        }
        public String anotherTest(int? id =null)
        {
            return "This is another method " + id.ToString();
            //return View();
        }
    }
}