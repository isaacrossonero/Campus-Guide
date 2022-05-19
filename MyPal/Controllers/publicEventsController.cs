using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
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
        private readonly IEmailSender _emailSender;

        //Constructor.
        public PublicEventsController(ApplicationDbContext db, UserManager<IdentityUser> userManager, IEmailSender emailSender)
        {
            _db = db;
            _userManager = userManager;
            _emailSender = emailSender;
        }
        //Displaying all the contents from the public events table.
        public async Task<IActionResult> IndexAsync(string button)
        {
            if (ModelState.IsValid)
            {
                CollectionDataModel coll = new CollectionDataModel();

                // Creating a list that will store the contents of all the data present in PublicEvents.
                IEnumerable<PublicEvents> objList = _db.PublicEvents.Where(publicEvent => publicEvent.EndTime > DateTime.Now);

                coll.PublicEventsList = objList.ToList();
                //coll.PublicEventsList = coll.PublicEventsList.OrderBy(pub => Convert.ToDateTime(pub.EndTime)).ToList();

                // If user is signed in (used for event attendance)
                if (User.IsInRole("User") || User.IsInRole("Admin"))
                {
                    // Gets the logged in user
                    var user = await _userManager.FindByNameAsync(User.Identity.Name);

                    coll.PublicEventAttendances = _db.PublicEventAttendances.Where(attend => attend.UserId.Equals(user.Id)).ToList();
                    coll.CurrentUserId = user.Id;
                }

                // This list will be used to diplay the name of the pinpoint id for each pinpoint
                coll.PinpointsList = _db.Pinpoints.Where(pinpoint => pinpoint.PinpointTypesId == 1).ToList();

                if (button == null)
                {
                    // Order Private Events by date
                    coll.PublicEventsList = coll.PublicEventsList.OrderBy(pub => Convert.ToDateTime(pub.EndTime)).ToList();
                }
                else if (button.Equals("endTime"))
                {
                    // Order Private Events by date
                    coll.PublicEventsList = coll.PublicEventsList.OrderBy(pub => Convert.ToDateTime(pub.EndTime)).ToList();
                }
                else if (button.Equals("startTime"))
                {
                    // Order Private Events by date
                    coll.PublicEventsList = coll.PublicEventsList.OrderBy(pub => Convert.ToDateTime(pub.EndTime)).ToList();
                }



                // Returning the list of objects that were retrived from the databse to the PublicEvents view.
                return View(coll);
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
        public async Task<IActionResult> CreateAsync(CollectionDataModel coll)
        {
            if (ModelState.IsValid)
            {
                // Creates an object of PublicEvents that refers to the PublicEvents instance passed by collection
                PublicEvents obj = coll.PublicEvents;

                // Adding the items to a public events object (they are not added to the db just yet).
                _db.PublicEvents.Add(obj);

                // Saving changes will add the above object to the databse. Without this method the data would not be added to the database. 
                _db.SaveChanges();

                // Sends email to all users that a new event has been created
                var userRole = _db.Roles.First(role => role.Name.Equals("User"));
                var usersId = _db.UserRoles.Where(user => user.RoleId.Equals(userRole.Id));
                foreach (var user in usersId)
                {
                    var emailUser = await _userManager.FindByIdAsync(user.UserId);
                    await _emailSender.SendEmailAsync(emailUser.Email, "New Event Created",
                                $"View new event named {obj.Name}");
                }

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

            // If Public Event is deleted, attendance related to that report should also be deleted
            var attendancesToDelete = _db.PublicEventAttendances.Where(attend => attend.PublicEventId == id);
            foreach (var upvote in attendancesToDelete)
            {
                _db.PublicEventAttendances.Remove(upvote);
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

        public IActionResult AttendEvent(string UserId, int Id)
        {
            if (ModelState.IsValid)
            {
                // Records attendance for that specific event (Id) and User (UserId)
                PublicEventAttendance attend = new PublicEventAttendance(UserId, Id);
                // Saves the attend to the database
                _db.PublicEventAttendances.Add(attend);
                // Gets the public event that the user is attending
                PublicEvents publicEvent = _db.PublicEvents.Single(publicEv => publicEv.Id == Id);
                // Increments attendace by 1
                publicEvent.Attendance++;
                // Updates table in datatbase
                _db.PublicEvents.Update(publicEvent);
                // Saving database changes
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}

