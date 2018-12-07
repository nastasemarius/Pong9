using Pong9.Data.Entities;
using System;
using System.Collections.Generic;
using Pong9.Data.DTO;

namespace Pong9.IRepositories
{
    public interface IBookingRepository
    {
        IEnumerable<Booking> GetAllBookings();
        Booking GetBookingById(Guid id);
        void CreateBooking(BookingDTO bookingDto);
        void EditBooking(Guid id, BookingDTO bookingDto);
        void DeleteBooking(Booking booking);
    }
}
