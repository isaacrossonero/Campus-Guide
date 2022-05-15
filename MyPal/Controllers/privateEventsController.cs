using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPal.Data;
using MyPal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPal.Controllers
{
    [Authorize(Roles="Admin,User")]
    public class PrivateEventsController : Controller
    {
        // Instance of the database.
        private readonly ApplicationDbContext _db;
        // Instance of identity
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;


        // Constructor.
        public PrivateEventsController(ApplicationDbContext db, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // Displaying all the contents from the private events table.
        public async Task<IActionResult> Index()
        {
            if (ModelState.IsValid)
            {
                // CollectionDataModel object
                CollectionDataModel coll = new CollectionDataModel();

                //Creating a list that will store the contents of all the data present in PrivateEvents.
                var user = await _userManager.FindByEmailAsync(User.Identity.Name);

                //Getting all the private events
                coll.PrivateEventsList = _db.PrivateEvents.ToList();
                // Filter out private events based on whether it is associated with logged on user and wheter it has already passed or not
                foreach (var element in coll.PrivateEventsList.ToList())
                {
                    if (!element.UserId.Equals(user.Id) && element.StartTime < DateTime.Now)
                    {
                        coll.PrivateEventsList.Remove(element);
                    }
                }


                // Order PrivateEvents and get next upcoming Event
                if (coll.PrivateEventsList.Count > 0)
                {
                    // Order Private Events by date
                    coll.PrivateEventsList.OrderBy(priv => priv.StartTime);
                    coll.PrivateEvents = coll.PrivateEventsList.First();
                }

                return View(coll);
            }
            return NotFound();
        }

        // Adding a new private event (GET)
        [HttpGet]
        public IActionResult Create()
        {
            if (ModelState.IsValid)
            {
                // Creates a new CollectionDataModel instace
                CollectionDataModel coll = new CollectionDataModel();

                // Adds an empty object of PublicEvents to coll.PublicEvents
                // This will be then used as the object of PublicEvents inside the view
                coll.PrivateEvents = new PrivateEvents();
                coll.PrivateEvents.StartTime = DateTime.Now;
                coll.PrivateEvents.EndTime = DateTime.Now.AddDays(1);

                // Populates coll's pinpoint list from database where pinpoint refers to a class
                // This list will be used to display the drop-down of pinpoints available
                coll.PinpointsList = _db.Pinpoints.Where(pinpoint => pinpoint.PinpointTypesId == 1).ToList();

                // Passes the collection object to the view
                return View(coll);
            }
            return NotFound();
        }

        //Adding a new private event (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAsync(CollectionDataModel coll)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(User.Identity.Name);

                PrivateEvents obj = coll.PrivateEvents;

                obj.UserId = user.Id;

                // Adding the items to a private events object (they are not added to the db just yet).
                _db.PrivateEvents.Add(obj);
                // Saving changes will add the above object to the databse. Without this method the data would not be added and saved to the database. 
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            // Returns the view with the errors
            coll.Pinpoints = new Pinpoints();

            coll.PinpointsList = _db.Pinpoints.Where(pinpoint => pinpoint.PinpointTypesId == 1).ToList();

            return View(coll);
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            // If the id does not exit.
            if (id == null || id == 0)
            {
                return NotFound();
            }

            // Obj that stores the whole report.
            CollectionDataModel coll = new CollectionDataModel();
            coll.PrivateEvents = _db.PrivateEvents.Find(id);
            coll.PinpointsList = _db.Pinpoints.Where(pinpoint => pinpoint.PinpointTypesId == 1).ToList();

            // Validation if the report does have an ID, but it is null.
            if (coll.PrivateEvents == null)
            {
                return NotFound();
            }

            //The object is being returned correctly to the Edit view.
            return View(coll);
        }

        //POST - Edit the report
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAsync(CollectionDataModel coll)
        {
            if (ModelState.IsValid)
            {
                //Here the default Id value of this obj is 0, where it should be the id of the selected event.
                PrivateEvents obj = coll.PrivateEvents;

                // Gets the logged in user
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                obj.UserId = user.Id;

                _db.PrivateEvents.Update(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            // Returns the view with the errors
            coll.Pinpoints = new Pinpoints();

            coll.PinpointsList = _db.Pinpoints.Where(pinpoint => pinpoint.PinpointTypesId == 1).ToList();

            return View(coll);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            // If the id does not exit.
            if (id == null || id == 0)
            {
                return NotFound();
            }

            // Obj that stores the private event.
            var obj = _db.PrivateEvents.Find(id);

            //Validation if the report does have an ID, but it is null.
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST - Delete the private event
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePrivateEvent(int? id)
        {
            // If the id does not exit.
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.PrivateEvents.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            // Remove private event from database and save changes
            _db.PrivateEvents.Remove(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }


        //GET - Getting all the the private events according to the email that user used to log in. 
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PrivateEvents>>> GetAllPrivateEventsAsync()
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(User.Identity.Name);
                return await _db.PrivateEvents.Where(userId => userId.UserId.Equals(user.Id)).ToListAsync();
            }
            return NotFound();   
        }
    }
}

