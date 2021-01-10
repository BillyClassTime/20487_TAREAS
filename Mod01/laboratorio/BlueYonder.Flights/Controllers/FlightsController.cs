using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlueYonder.Flights.Models;


namespace BlueYonder.Flights.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {

        private readonly FlightsContext _context;
        public FlightsController(FlightsContext context)
        {
            _context = context;
        }

        // GET api/flights
        [HttpGet]
        public IEnumerable<Flight> Get()
        {
            return _context.Flights.ToList();
        }

        // POST api/flights
        [HttpPost]
        public IActionResult Post([FromBody]Flight flight)
        {
            _context.Flights.Add(flight);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), flight.Id);
        }
    }
}
