using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TripHunt.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult Home()
        {
            return View("Home");
        }

        public ViewResult AddPackages()
        {
            return View("AddPackages");
        }
        public ViewResult Testing()
        {
            return View("Testing");
        }
    }
}

