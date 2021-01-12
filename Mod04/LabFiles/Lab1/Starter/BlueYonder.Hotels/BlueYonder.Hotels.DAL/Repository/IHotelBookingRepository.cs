using BlueYonder.Hotels.DAL.Database;
using BlueYonder.Hotels.DAL.Models;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BlueYonder.Hotels.DAL.Repository
{
    public interface  IHotelBookingRepository
    {
        IEnumerable<Room> GetAvaliabileByDate(DateTime date);
                
        IEnumerable<Reservation> GetAllReservation();

        Task DeleteReservation(int reservationId);
    }
}
