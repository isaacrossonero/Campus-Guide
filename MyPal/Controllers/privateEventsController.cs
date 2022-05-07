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
        public async Task<IActionResult> Index()
        {
            //Creating a list that will store the contents of all the data present in PrivateEvents.
            var user = await _userManager.FindByEmailAsync(User.Identity.Name);
            //Getting all the private events, sorting the result by most urgent date.
            IEnumerable<PrivateEvents> objList = await _db.PrivateEvents.Where(userId => userId.UserId.Equals(user.Id)).OrderBy(date => date.StartTime).ToListAsync();

            //Removes all past events that are no longer needed.
            foreach(var a in objList)
            {
                if(a.StartTime < DateTime.Now)
                {
                    _db.PrivateEvents.Remove(a);
                    _db.SaveChanges();
                }
            }

            //Creates new list which represnts the updated version of teh pervious one.
            IEnumerable<PrivateEvents> list = objList;

            PrivateEvents e = list.First();

            //Creating a new tuple.
            var tupleModel = new Tuple<IEnumerable<PrivateEvents>, PrivateEvents> (list, e);

            //Returning the list of objects that were retrived from the databse to the privateEvents view.
            return View(tupleModel);
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


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            // If the id does not exit.
            if (id == null || id == 0)
            {
                return NotFound();
            }

            // Obj that stores the whole report.
            CollectionaDataModel coll = new CollectionaDataModel();
            coll.Event = _db.PrivateEvents.Find(id);

            // Validation if the report does have an ID, but it is null.
            if (coll.Event == null)
            {
                return NotFound();
            }

            //The object is being returned correctly to the Edit view.
            return View(coll);
        }

        //POST - Edit the report
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAsync(CollectionaDataModel coll)
        {
            if (ModelState.IsValid)
            {
                //Here the default Id value of this obj is 0, where it should be the id of the selected event.
                PrivateEvents obj = coll.Event;

                // Gets the logged in user
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                obj.UserId = user.Id;
                _db.PrivateEvents.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
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

            // Obj that stores the whole report.
            var obj = _db.PrivateEvents.Find(id);

            //Validation if the report does have an ID, but it is null.
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST - Delete the report
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

            _db.PrivateEvents.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }



        [HttpGet]
        public async Task<ActionResult<IEnumerable<PrivateEvents>>> GetAllPrivateEventsAsync()
        {
            var user = await _userManager.FindByEmailAsync(User.Identity.Name);
            return await _db.PrivateEvents.Where(userId => userId.UserId.Equals(user.Id)).ToListAsync();
        }
    }
}
