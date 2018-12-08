using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pong9.Data.Entities;
using Pong9.IRepositories;
using Pong9.Persistence;

namespace Pong9.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        //private readonly IBookingRepository _bookingRepository;

        //public BookingController(IBookingRepository bookingRepository)
        //{
        //    _bookingRepository = bookingRepository;
        //}

        //// GET: api/Booking
        //[HttpGet]
        //public IEnumerable<Booking> GetBookings()
        //{
        //    return _bookingRepository.GetAllBookings();
        //}

        //// GET: api/Booking/5
        //[HttpGet("{id}")]
        //public IActionResult GetBooking([FromRoute] Guid id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var booking = _bookingRepository.GetBookingById(id);

        //    if (booking == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(booking);
        //}

        //// PUT: api/Booking/5
        //[HttpPut("{id}")]
        //public IActionResult PutBooking([FromRoute] Guid id, [FromBody] Booking booking)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != booking.BookingId)
        //    {
        //        return BadRequest();
        //    }

        //    _bookingRepository.EditBooking(id, );

        //    return NoContent();
        //}

        //// POST: api/Booking
        //[HttpPost]
        //public async Task<IActionResult> PostBooking([FromBody] Booking booking)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //  //  _context.Bookings.Add(booking);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetBooking", new { id = booking.BookingId }, booking);
        //}

        //// DELETE: api/Booking/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteBooking([FromRoute] Guid id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var booking = await _context.Bookings.FindAsync(id);
        //    if (booking == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Bookings.Remove(booking);
        //    await _context.SaveChangesAsync();

        //    return Ok(booking);
        //}

        //private bool BookingExists(Guid id)
        //{
        //    return _context.Bookings.Any(e => e.BookingId == id);
        //}
    }
}