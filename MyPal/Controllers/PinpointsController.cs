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
    }
}
