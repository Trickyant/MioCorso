using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MioCorso.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult index()
        {
            return View();
        }
        public IActionResult Detail(string id)
        {
            return View();
        }

    }
}