using Microsoft.AspNetCore.Authorization;
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
    public class PinpointsController : Controller
    {
        //Instance of the database.
        private readonly ApplicationDbContext _db;

        // Constructor
        public PinpointsController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET Request to getAllPinpoints
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pinpoints>>> GetAllPinpoints()
        {
            if (ModelState.IsValid)
            {
                return await _db.Pinpoints.ToListAsync();
            }
            return NotFound();
        }

        // GET Request for all pinpoints of Todays Events
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pinpoints>>> GetPinpointsOfTodaysEvents()
        {
            if (ModelState.IsValid)
            {
                // Collection data model class
                CollectionDataModel coll = new CollectionDataModel();

                // Getting today's public Events
                coll.PublicEventsList = await _db.PublicEvents.Where(publicEvent => publicEvent.StartTime == DateTime.Now.Date).ToListAsync();

                // Pinpoints related to today's public events
                var pinpointPublicEventList = new List<int>();
                foreach (var element in coll.PublicEventsList)
                {
                    pinpointPublicEventList.Add(element.PinpointId);
                }

                // Filtering out pinpoints
                coll.PinpointsList = await _db.Pinpoints.Where(pinpoint => pinpoint.PinpointTypesId != 1).ToListAsync();
                coll.PinpointsList.AddRange(await _db.Pinpoints.Where(pinpoint => pinpointPublicEventList.Contains(pinpoint.Id)).ToListAsync());

                // Returing pinpoints list
                return coll.PinpointsList;
            }
            return NotFound();
        }

        // Returns a list of pinpoint ids from start to end of the shortest path
        [HttpGet]
        public async Task<ActionResult<IEnumerable<int>>> GetNavigationId(int start, int end)
        {
            if (ModelState.IsValid)
            {
                Navigation nav = new Navigation(_db);
                List<Pinpoints> path = nav.CalculatePath(start, end);
                List<int> pathIds = new();

                foreach (var p in path)
                {
                    pathIds.Add(p.Id);
                }
                return pathIds;
            }
            return NotFound();
        }

        //Retreive session variable based in the key inputted
        [HttpGet]
        public Pinpoints GetSessionLocation(string key)
        {
            Pinpoints pinpoint = HttpContext.Session.GetObjectFromJson<Pinpoints>(key);
            return pinpoint;
        }

        //Sets a session variable for Location via the string key
        [HttpPost]
        public void SetSessionLocation(string key, Pinpoints pinpoint)
        {
            HttpContext.Session.SetObjectAsJson(key, pinpoint);
        }

        // GET: api/Pinpoints/5
        [HttpGet]
        public async Task<ActionResult<Pinpoints>> getPinpointById(int id)
        {
            if (ModelState.IsValid)
            {
                var pinpoints = await _db.Pinpoints.FindAsync(id);

                if (pinpoints == null)
                {
                    return NotFound();
                }

                return pinpoints;
            }
            return NotFound();
        }

        //Adding a new report (Get - Create)
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateAsync(CollectionDataModel coll)
        {
            if (ModelState.IsValid)
            {
                // Creates an object of Pinpoints that refers to the Pinpoints instance passed by collection
                Pinpoints obj = coll.Pinpoints;

                obj.FloorId = 3;

                // Get all pinpoints
                coll.PinpointsList = _db.Pinpoints.OrderBy(pinpoint => pinpoint.Id).ToList();
                // Get last element
                Pinpoints pin = coll.PinpointsList.Last();
                obj.Id = pin.Id + 1;


                //Adding the items to the Pinpoints Database(they are not saved to the db just yet).
                _db.Pinpoints.Add(obj);
                // Saving changes will add the above object to the databse. Without this method the data would not be added. 
                _db.SaveChanges();

                return RedirectToAction("Index", "PublicEvents");
            }
            return View(coll);
        }
    }
}
