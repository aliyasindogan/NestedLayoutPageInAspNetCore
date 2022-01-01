using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NestedLayoutPageInAspNetCore.Controllers
{
    public class NestedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Nested1()
        {
            return View();
        }
        public IActionResult Nested2()
        {
            return View();
        }

        public IActionResult Nested3()
        {
            return View();
        }
    }
}
