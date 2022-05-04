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
            return await _db.Pinpoints.Where(pinpoint => pinpoint.PinpointTypesId != 4).ToListAsync();
        }

        // GET Request for all pinpoints of Todays Events
        public async Task<ActionResult<IEnumerable<Pinpoints>>> GetPinpointsOfTodaysEvents()
        {
            CollectionDataModel coll = new CollectionDataModel();
            // Getting today's public events and their pinpointId
            coll.PublicEventsList = await _db.PublicEvents.Where(publicEvent => publicEvent.StartTime == DateTime.Now.Date).ToListAsync();
            // Getting the list of the pinpoins
            var pinpointIdList = new List<int>();
            foreach(var element in coll.PublicEventsList)
            {
                pinpointIdList.Add(element.PinpointId);
            }
            return await _db.Pinpoints.Where(pinpoint => pinpointIdList.Contains(pinpoint.Id)).ToListAsync();
        }
    }
}
