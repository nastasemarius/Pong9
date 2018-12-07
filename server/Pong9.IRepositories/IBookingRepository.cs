using Pong9.Data.Entities;
using System;
using System.Collections.Generic;

namespace Pong9.IRepositories
{
    public interface IBookingRepository
    {
        IEnumerable<Booking> GetAllBookings();
        Booking GetBookingById(Guid id);
        void CreateBooking(Booking Booking);
        void EditBooking(Booking Booking);
        void DeleteBooking(Booking Booking);
    }
}
