using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPal.Controllers
{
    public class publicEventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
