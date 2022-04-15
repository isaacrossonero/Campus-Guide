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
            // Creates a new CollectionDataModel instace
            CollectionDataModel coll = new CollectionDataModel();
            // Adds an empty object of PublicEvents to coll.PublicEvents
            // This will be then used as the object of PublicEvents inside the view
            coll.PublicEvents = new PublicEvents();
            // Populates coll's pinpoint list from database where pinpoint refers to a class
            // This list will be used to display the drop-down of pinpoints available
            coll.PinpointsList = _db.Pinpoints.Where(pinpoint => pinpoint.PinpointTypesId == 1).ToList();
            //Passes the collection object to the view
            return View(coll);
        }

        //Adding a new category to the table (POST - CREATE).
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(CollectionDataModel coll)
        {
            // Creates an object of PublicEvents that refers to the PublicEvents instance passed by collection
            PublicEvents obj = coll.PublicEvents;
            //Adding the items to a private events object(they are not added to the db just yet).
            _db.PublicEvents.Add(obj);
            //Saving changes will add the above object to teh databse. Without this method the data would ot be added. 
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

