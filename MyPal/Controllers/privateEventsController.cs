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
    [Authorize(Roles="Admin,User")]
    public class PrivateEventsController : Controller
    {
        //Instance of the database.
        private readonly ApplicationDbContext _db;
        // Instance of identity
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;


        //Constructor.
        public PrivateEventsController(ApplicationDbContext db, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        //Displaying all the contents from the private events table.
        public async Task<IActionResult> Index(String date)
        {
            //Creating a list that will store the contents of all the data present in PrivateEvents.
            var user = await _userManager.FindByEmailAsync(User.Identity.Name);
            IEnumerable<PrivateEvents> objList = _db.PrivateEvents.Where(userId => userId.UserId.Equals(user.Id));

            //Returning the list of objects that were retrived from the databse to the privateEvents view.
            return View(objList);
        }


        //Adding a new category to the table (GET - CREATE).
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //Adding a new category to the table (POST - CREATE).
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAsync(PrivateEvents obj)
        {
            var user = await _userManager.FindByEmailAsync(User.Identity.Name);

            obj.UserId = user.Id;
            //Adding the items to a private events object(they are not added to the db just yet).
            _db.PrivateEvents.Add(obj);
            //Saving changes will add the above object to teh databse. Without this method the data would ot be added. 
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
