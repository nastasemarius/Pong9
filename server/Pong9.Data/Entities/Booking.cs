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

        public static Booking CreateBooking()
        {
            var instance = new Booking
            {
                BookingId = Guid.NewGuid(),
                Players = new HashSet<User>()
            };

            return instance;
        }

        public void UpdateBooking(DateTime startTime, DateTime endTime, User creator, Guid tableId,
            ICollection<User> players)
        {
            StartTime = startTime;
            EndTime = endTime;
            Creator = creator;
            TableId = tableId;
            Players = players;
        }
    }
}
