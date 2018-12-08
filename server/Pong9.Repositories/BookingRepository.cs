using System;
using System.Collections.Generic;
using System.Linq;
using Pong9.Data.DTO;
using Pong9.Data.Entities;
using Pong9.IRepositories;
using Pong9.Persistence;

namespace Pong9.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public BookingRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IEnumerable<Booking> GetAllBookings()
        {
            return _applicationDbContext.Bookings.ToList();
        }

        public Booking GetBookingById(Guid id)
        {
            return _applicationDbContext.Bookings.SingleOrDefault(b => b.BookingId == id);
        }

        public Booking GetBookingByStartTimeAndCreator(DateTime startTime, User creator)
        {
            return _applicationDbContext.Bookings.SingleOrDefault(b =>
                b.StartTime == startTime && b.Creator.UserId == creator.UserId);
        }

        public void CreateBooking(BookingDTO bookingDto)
        {
            var booking = Booking.CreateBooking();
            var creator = _applicationDbContext.Users.Find(bookingDto.CreatorId);
            booking.UpdateBooking(bookingDto.StartTime, bookingDto.EndTime, creator, bookingDto.TableId, bookingDto.Players);

            _applicationDbContext.Bookings.Add(booking);
            _applicationDbContext.SaveChanges();
        }

        public void EditBooking(Guid id, BookingDTO bookingDto)
        {
            var bookingToEdit = _applicationDbContext.Bookings.Find(id);
            var creator = _applicationDbContext.Users.Find(bookingDto.CreatorId);
            bookingToEdit.UpdateBooking(bookingDto.StartTime, bookingDto.EndTime, creator, bookingDto.TableId, bookingDto.Players);

            _applicationDbContext.Bookings.Update(bookingToEdit);
            _applicationDbContext.SaveChanges();
        }

        public void DeleteBooking(Booking booking)
        {
            _applicationDbContext.Bookings.Remove(booking);
            _applicationDbContext.SaveChanges();
        }
    }
}
