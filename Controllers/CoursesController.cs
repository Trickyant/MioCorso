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
            return Content("Sono Index");
        }
        public IActionResult Detail(string id)
        {
            return Content($"Sono Detail , ho ricevuto l' id {id}");
        }

    }
}