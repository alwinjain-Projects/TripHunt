using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripHunt.Models;

namespace AlwinJ_301058280.Controllers
{
    public class HomeController : Controller
    {
       

        public ViewResult Index()
        {
            return View("LoginPage");

        }
       

        public ViewResult Registration()
        {
            return View("Registration");
        }

       

        [HttpPost]
        public RedirectToActionResult LoginAction(LoginDetails logDetails)
        {
            if (logDetails.userName.Equals("alwinjain1997@gmail.com"))
            {
                return RedirectToAction("Home", "Customer", new { area = "customer" });
            }
            else
                return RedirectToAction("Home", "Admin", new { area = "admin" });

        }




    }
}
