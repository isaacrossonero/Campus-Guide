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
    public class MyPalController : Controller
    {
        //Instance of the database.
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public MyPalController(ApplicationDbContext db, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Index()
        {
            if (ModelState.IsValid)
            {
                // CollectionDataModel Variable
                CollectionDataModel coll = new CollectionDataModel();

                // Adding public events to collection data model public events list variable
                coll.PublicEventsList = _db.PublicEvents.Where(publicEvent => publicEvent.EndTime > DateTime.Now).ToList();
                coll.PublicEventsList = coll.PublicEventsList.OrderBy(pub => Convert.ToDateTime(pub.EndTime)).ToList();

               

                // Adding private events to collection data model private events list variable
                if (_signInManager.IsSignedIn(User))
                { 
                    var user = await _userManager.FindByEmailAsync(User.Identity.Name);


                    coll.PublicEventAttendances = _db.PublicEventAttendances.ToList();
                    coll.AttendingPublicEventsList = new();
                    for (int i = 0; i < coll.PublicEventsList.Count; i++)
                    {
                        PublicEvents p = coll.PublicEventsList.ElementAt(i);
                        foreach(var element in coll.PublicEventAttendances)
                        {
                            // If user is signed in the same and is attending
                            if (element.PublicEventId == p.Id && element.UserId.Equals(user.Id))
                            {
                                coll.AttendingPublicEventsList.Add(p);
                            }
                        }
                    }

                        coll.PrivateEventsList = _db.PrivateEvents.Where(privateEvent => privateEvent.UserId.Equals(user.Id) && privateEvent.EndTime > DateTime.Now).ToList();

                    // Order Private Events by date
                    coll.PrivateEventsList = coll.PrivateEventsList.OrderBy(priv => Convert.ToDateTime(priv.EndTime)).ToList();
                }

                // This list will be used to diplay the name of the pinpoint id for each pinpoint
                coll.PinpointsList = _db.Pinpoints.Where(pinpoint => pinpoint.PinpointTypesId == 1).ToList();

                return View(coll);
            }
            return NotFound();
        }
    
    }
}
