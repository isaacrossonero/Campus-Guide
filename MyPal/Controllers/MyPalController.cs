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
                coll.PublicEventsList = _db.PublicEvents.Where(publicEvent => publicEvent.StartTime > DateTime.Now).ToList();

                // Adding private events to collection data model private events list variable
                if (_signInManager.IsSignedIn(User))
                {
                    var user = await _userManager.FindByEmailAsync(User.Identity.Name);
                    coll.PrivateEventsList = _db.PrivateEvents.Where(privateEvent => privateEvent.UserId.Equals(user.Id) && privateEvent.StartTime > DateTime.Now).ToList();
                }
                return View(coll);
            }
            return NotFound();
        }
    
    }
}
