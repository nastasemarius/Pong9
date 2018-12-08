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

        public void CreateBooking(BookingDTO bookingDto)
        {
            var booking = Booking.CreateBooking();
            booking.UpdateBooking(bookingDto.StartTime, bookingDto.EndTime, bookingDto.Creator, bookingDto.TableId, bookingDto.Players);

            _applicationDbContext.Bookings.Add(booking);
            _applicationDbContext.SaveChanges();
        }

        public void EditBooking(Guid id, BookingDTO bookingDto)
        {
            var bookingToEdit = _applicationDbContext.Bookings.Find(id);
            bookingToEdit.UpdateBooking(bookingDto.StartTime, bookingDto.EndTime, bookingDto.Creator, bookingDto.TableId, bookingDto.Players);

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
