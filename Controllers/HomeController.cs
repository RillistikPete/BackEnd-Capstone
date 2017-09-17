using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BECaptsone.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string id)
        {
             if ( id == "Doctor")
            {
                return View("RegisterDoctor");
            }
            if ( id == "Patient")
            {
                return View("RegisterPatient");
            }
                return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
