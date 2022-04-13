using Microsoft.AspNetCore.Mvc;
using MyPal.Data;
using MyPal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPal.Controllers
{
    public class LoginRegisterController : Controller
    {
        //Instance of the database.
        private readonly ApplicationDbContext _db;

        //Constructor.
        public LoginRegisterController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        //method to login
        [HttpGet]
        public IActionResult Login(String Name, String Password)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Users obj)
        {
            /*
            _db.Users.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
            */
            return View();
        }
    }
}
