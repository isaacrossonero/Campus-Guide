using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyPal.Data;
using MyPal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPal.Controllers
{
    public class PublicEventsController : Controller
    {
        //Instance of the database.
        private readonly ApplicationDbContext _db;

        //Constructor.
        public PublicEventsController(ApplicationDbContext db)
        {
            _db = db;
        }
        //Displaying all the contents from the public events table.
        public IActionResult Index()
        {
            //Creating a list that will store the contents of all the data present in PublicEvents.
            IEnumerable<PublicEvents> objList = _db.PublicEvents;

            //Returning the list of objects that were retrived from the databse to the PublicEvents view.
            return View(objList);
        }

        [Authorize(Roles = "Admin")]
        //Adding a new category to the table (GET - CREATE).
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //Adding a new category to the table (POST - CREATE).
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(PublicEvents obj)
        {
            //Adding the items to a private events object(they are not added to the db just yet).
            _db.PublicEvents.Add(obj);
            //Saving changes will add the above object to teh databse. Without this method the data would ot be added. 
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

