using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            //return View();
            return View();
        }

        // GET: /HelloWorld/Welcome/
        public IActionResult Welcome(string name, int numTimes=1)
        {
            //return $"Hello, {name}, ID: {id}";
            ViewData["Message"] = "Hello! " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
