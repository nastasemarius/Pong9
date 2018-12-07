using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pong9.Data.Entities
{
    public class Booking
    {
        [Key]
        public Guid BookingId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public User Creator { get; set; }

        public Guid TableId { get; set; }

        public ICollection<User> Players { get; set; }

        public Booking CreateBooking()
        {
            var instance = new Booking
            {
                BookingId = Guid.NewGuid(),
                StartTime = DateTime.UtcNow,
                EndTime = DateTime.UtcNow,
                TableId = Guid.NewGuid(),
                Players = new HashSet<User>()
            };

            return instance;
        }
    }
}
