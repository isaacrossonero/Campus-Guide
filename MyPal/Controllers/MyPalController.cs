using Microsoft.AspNetCore.Mvc;
using MyPal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPal.Controllers
{
    public class MyPalController : Controller
    {
        //Instance of the database.
        private readonly ApplicationDbContext _db;

        public IActionResult Index()
        {
            return View();
        }


    }
}
