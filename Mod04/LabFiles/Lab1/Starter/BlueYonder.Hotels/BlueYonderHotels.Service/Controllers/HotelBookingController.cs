using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueYonder.Hotels.DAL.Models;
using BlueYonder.Hotels.DAL.Repository;
using BlueYonderHotels.Service.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace BlueYonderHotels.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelBookingController : ControllerBase
    {
        /*
        private readonly HotelBookingRepository _hotelBookingRepository;

        public HotelBookingController()
        {
            _hotelBookingRepository = new HotelBookingRepository();
        }
        */

        private readonly IHotelBookingRepository _hotelBookingRepository;
        public HotelBookingController(IHotelBookingRepository hotelBookingRepository)
        {
            _hotelBookingRepository = hotelBookingRepository;
        }

        [HttpGet("Availability/{date}")]
        [Cache("X-No-Cache")]
        public IEnumerable<Room> GetAvailability(DateTime date)
        {
            return _hotelBookingRepository.GetAvaliabileByDate(date);
        }
        
        [HttpGet("Reservation")]
        public IEnumerable<Reservation> GetReservation()
        {
            return _hotelBookingRepository.GetAllReservation();
        }

        
        [HttpDelete("Reservation/{reservationId}")]
        public async Task DeleteReservation(int reservationId)
        {
            await _hotelBookingRepository.DeleteReservation(reservationId);
        }
       
    }
}
