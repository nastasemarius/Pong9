using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pong9.Data.Entities;
using Pong9.IRepositories;
using Pong9.IServices;
using Pong9.Persistence;

namespace Pong9.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BookingController : Controller
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult GetBookingsFromCurrentDay(Guid tableId)
        {
            var bookings = _bookingService.GetBookingsFromCurrentDay(tableId);

            if (!bookings.IsSuccess)
            {
                return BadRequest(new {message = "No bookings from current day were found."});
            }

            return Ok(bookings.Value);
        }

        [HttpGet]
        public IActionResult GetUsersForBooking(Guid bookingId)
        {
            var users = _bookingService.GetUsersForBooking(bookingId);

            if (!users.IsSuccess)
            {
                return BadRequest(new {message = "Invalid booking."});
            }

            return Ok(users.Value);
        }
    }
}