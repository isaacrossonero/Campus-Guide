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
            CollectionDataModel COLL = new CollectionDataModel();
            COLL.PublicEventsList = _db.PublicEvents.ToList();//Add LINQ where to current date
            if (_signInManager.IsSignedIn(User))
            {
                var user = await _userManager.FindByEmailAsync(User.Identity.Name);
                COLL.PrivateEventsList = _db.PrivateEvents.Where(userId => userId.UserId.Equals(user.Id)).ToList();
            }
            return View(COLL);
        }
    
    }
}
