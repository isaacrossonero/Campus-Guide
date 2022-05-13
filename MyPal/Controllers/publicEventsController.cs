using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        //Constructor.
        public PublicEventsController(ApplicationDbContext db, UserManager<IdentityUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        //Displaying all the contents from the public events table.
        public IActionResult Index()
        {
            if (ModelState.IsValid)
            {
                // Creating a list that will store the contents of all the data present in PublicEvents.
                IEnumerable<PublicEvents> objList = _db.PublicEvents.Where(publicEvent => publicEvent.StartTime > DateTime.Now);

                // Returning the list of objects that were retrived from the databse to the PublicEvents view.
                return View(objList);
            }
            return NotFound();
        }

        [Authorize(Roles = "Admin")]
        //Adding a new category to the table (GET - CREATE).
        [HttpGet]
        public IActionResult Create()
        {
            if (ModelState.IsValid)
            {
                // Creates a new CollectionDataModel instace
                CollectionDataModel coll = new CollectionDataModel();

                // Adds an empty object of PublicEvents to coll.PublicEvents
                // This will be then used as the object of PublicEvents inside the view
                coll.PublicEvents = new PublicEvents();
                coll.PublicEvents.StartTime = DateTime.Now;
                coll.PublicEvents.EndTime = DateTime.Now.AddDays(1);

                // Populates coll's pinpoint list from database where pinpoint refers to a class
                // This list will be used to display the drop-down of pinpoints available
                coll.PinpointsList = _db.Pinpoints.Where(pinpoint => pinpoint.PinpointTypesId == 1).ToList();

                // Passes the collection object to the view
                return View(coll);
            }
            return NotFound();
            
        }

        //Adding a new category to the table (POST - CREATE).
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(CollectionDataModel coll)
        {
            if (ModelState.IsValid)
            {
                // Creates an object of PublicEvents that refers to the PublicEvents instance passed by collection
                PublicEvents obj = coll.PublicEvents;

                // Adding the items to a public events object (they are not added to the db just yet).
                _db.PublicEvents.Add(obj);

                // Saving changes will add the above object to the databse. Without this method the data would not be added to the database. 
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            // Returns the view with the errors
            coll.Pinpoints = new Pinpoints();

            coll.PinpointsList = _db.Pinpoints.Where(pinpoint => pinpoint.PinpointTypesId == 1).ToList();

            return View(coll);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            // If the id does not exit.
            if (id == null || id == 0)
            {
                return NotFound();
            }

            // Obj that stores the whole public event.
            CollectionDataModel coll = new CollectionDataModel();
            coll.PublicEvents = _db.PublicEvents.Find(id);

            coll.PinpointsList = _db.Pinpoints.Where(pinpoint => pinpoint.PinpointTypesId == 1).ToList();

            // Validation if the public event does have an ID, but it is null.
            if (coll.PublicEvents == null)
            {
                return NotFound();
            }

            // The object is being returned correctly to the Edit view.
            return View(coll);
        }

        //POST - Edit the public event
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditAsync(CollectionDataModel coll)
        {
            if (ModelState.IsValid)
            {
                PublicEvents obj = coll.PublicEvents;

                // Gets the logged in user
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                _db.PublicEvents.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            // Returns the view with the errors
            coll.Pinpoints = new Pinpoints();

            coll.PinpointsList = _db.Pinpoints.Where(pinpoint => pinpoint.PinpointTypesId == 1).ToList();

            return View(coll);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            // If the id does not exit.
            if (id == null || id == 0)
            {
                return NotFound();
            }

            // Obj that stores the whole public event.
            var obj = _db.PublicEvents.Find(id);

            // Validation if the public event does have an ID, but it is null.
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST - Delete the public event
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public IActionResult DeletePublicEvent(int? id)
        {
            // If the id does not exit.
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.PublicEvents.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            _db.PublicEvents.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

