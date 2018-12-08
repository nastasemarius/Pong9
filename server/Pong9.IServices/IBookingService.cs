using System;
using System.Collections.Generic;
using System.Text;
using Pong9.Data.DTO;
using Pong9.Data.Entities;
using Pong9.Services.Helpers;

namespace Pong9.IServices
{
    public interface IBookingService
    {
        ApiResult<List<Booking>> GetBookingsFromCurrentDay(Guid tableId);
        ApiResult<List<User>> GetUsersForBooking(Guid bookingId);
        ApiResult<Booking> CreateBooking(BookingDTO bookingDto);
    }
}
