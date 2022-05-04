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
            return await _db.Pinpoints.ToListAsync();
        }

        // GET Request for all pinpoints of Todays Events
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pinpoints>>> GetPinpointsOfTodaysEvents()
        {
            CollectionDataModel coll = new CollectionDataModel();
            // Getting today's public events and their pinpointId
            coll.PublicEventsList = await _db.PublicEvents.Where(publicEvent => publicEvent.StartTime == DateTime.Now.Date).ToListAsync();
            // Getting the list of the pinpoints of today's public events
            var pinpointPublicEventList = new List<int>();
            foreach(var element in coll.PublicEventsList)
            {
                pinpointPublicEventList.Add(element.PinpointId);
            }
            // Adds all pinpoints except rooms (stairs, navigation nodes, entrance)
            coll.PinpointsList = await _db.Pinpoints.Where(pinpoint => pinpoint.PinpointTypesId != 1).ToListAsync();
            // Append rooms that are associated with today's events (Public Events)
            coll.PinpointsList.AddRange(await _db.Pinpoints.Where(pinpoint => pinpointPublicEventList.Contains(pinpoint.Id)).ToListAsync());
            return coll.PinpointsList;
        }

        //Returns a list of Pinpoints Ids from start to end of the shortest path
        [HttpGet]
        public async Task<ActionResult<IEnumerable<int>>> GetNavigationId(int start, int end)
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
            var pinpoints = await _db.Pinpoints.FindAsync(id);

            if (pinpoints == null)
            {
                return NotFound();
            }

            return pinpoints;
        }
    }
}
