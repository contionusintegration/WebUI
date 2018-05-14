using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreWithTest.Models;
using Business;

namespace CoreWithTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Class1 class1 = new Class1();
            ViewData["Sum"] = "Sum of 3 + 100 =" + class1.Sum(2, 103);
            return View();
        }

        public IActionResult About()
        {
            Class1 class1 = new Class1();

            ViewData["Message"] = "Sum of 2 + 100 is" + class1.Sum(2, 100);

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
