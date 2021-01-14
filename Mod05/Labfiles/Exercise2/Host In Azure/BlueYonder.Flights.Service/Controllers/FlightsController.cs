using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlueYonder.Flights.Service.Models;
using BlueYonder.Flights.Service.Database;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;

namespace BlueYonder.Flights.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {

       
        [HttpGet]
        [Route("entorno")]
        public IEnumerable<Flight> entorno()
                {
                    var fs = new List<Flight>() ;
                
                IDictionary  environmentVariables = Environment.GetEnvironmentVariables();
                int i = 1;
                foreach (DictionaryEntry de in environmentVariables)
                {
                    Flight f = new Flight();
                    f.FlightId =i;
                    f.Origin = de.Key.ToString();
                    f.Destination= de.Value.ToString();
                    fs.Add (f);
                }
                return fs;
                }

            
       

       
        

        [HttpGet]
        public IEnumerable<Flight> GetAllFlights()
        {
            using (var flightContext = new FlightContext())
            {
                var flights = flightContext.Flights.Include(f => f.Travelers).ToList();
                return flights;
            }
        }

        [HttpPost]
        [Route("BookFlight")]
        public void BookFlight(int flightId, [FromBody]IEnumerable<Traveler> travelers)
        {
            using (var flightContext = new FlightContext())
            {
                var flight = flightContext.Flights.FirstOrDefault(f => f.FlightId == flightId);
                if (flight != null)
                {
                    flight.Travelers = travelers.ToList();
                    flightContext.SaveChanges();
                }
            }
        }
    }
}

