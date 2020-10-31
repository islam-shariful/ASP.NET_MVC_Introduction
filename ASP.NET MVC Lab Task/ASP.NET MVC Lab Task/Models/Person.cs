using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_Lab_Task.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string BloodGroup { get; set; }
        public string Gender { get; set; }
        public string DateOfBirth { get; set; }
    }
}