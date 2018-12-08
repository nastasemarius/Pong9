using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pong9.Data.Entities;
using Pong9.IRepositories;
using Pong9.IServices;
using Pong9.Services.Helpers;

namespace Pong9.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IPingPongTableRepository _pingPongTableRepository;

        public BookingService(IBookingRepository bookingRepository, IPingPongTableRepository pingPongTableRepository)
        {
            _bookingRepository = bookingRepository;
            _pingPongTableRepository = pingPongTableRepository;
        }

        public ApiResult<List<Booking>> GetBookingsFromCurrentDay(Guid tableId)
        {
            var table = _pingPongTableRepository.GetPingPongTableById(tableId);

            if (table == null)
            {
                return new ApiResult<List<Booking>>(false);
            }

            var bookings = _bookingRepository.GetAllBookings()
                .Where(b => b.TableId == tableId && b.StartTime.Day.Equals(DateTime.Today.Day));

            if (!bookings.Any())
            {
                return new ApiResult<List<Booking>>(false);
            }

            return new ApiResult<List<Booking>>(bookings.ToList());
        }

        public ApiResult<List<User>> GetUsersForBooking(Guid bookingId)
        {
            var booking = _bookingRepository.GetBookingById(bookingId);

            if (booking == null)
            {
                return new ApiResult<List<User>>(false);
            }

            var users = booking.Players.ToList();

            if (!users.Any())
            {
                return new ApiResult<List<User>>(false);
            }

            return new ApiResult<List<User>>(users);
        }
    }
}
