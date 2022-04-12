using Microsoft.AspNetCore.Mvc;
using MyPal.Data;
using MyPal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPal.Controllers
{
    public class PrivateEventsController : Controller
    {
        //Instance of the database.
        private readonly ApplicationDbContext _db;

        //Constructor.
        public PrivateEventsController(ApplicationDbContext db)
        {
            _db = db;
        }

        //Displaying all the contents from the private events table.
        public IActionResult Index()
        {
            //Creating a list that will store the contents of all the data present in PrivateEvents.
            IEnumerable<PrivateEvents> objList = _db.PrivateEvents;

            //Returning the list of objects that were retrived from the databse to the privateEvents view.
            return View(objList);
        }

        //Adding a new category to the table (GET - CREATE).
        public IActionResult Create()
        {
            //Creating a list that will store the contents of all the data present in PrivateEvents.
            IEnumerable<PrivateEvents> objList = _db.PrivateEvents;

            //Returning the list of objects that were retrived from the databse to the privateEvents view.
            return View(objList);
        }

        //Adding a new category to the table (POST - CREATE).
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PrivateEvents obj)
        {
            //Adding the items to a private events object(they are not added to the db just yet).
            _db.PrivateEvents.Add(obj);
            //Saving changes will add the above object to teh databse. Without this method the data would ot be added. 
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
