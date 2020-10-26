using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Lab_Task.Controllers
{
    public class TestController : Controller
    {
        // GET: Home
        public String Test()
        {
            return "Hello C#";
            //return View();
        }
        public String anotherTest(int? id =null)
        {
            return "This is another method " + (id.ToString()+2);
            //return View();
        }
    }
}