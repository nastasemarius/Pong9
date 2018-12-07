using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pong9.Data.Entities
{
    public class PingPongTable
    {
        [Key]
        public Guid PingPongTableId { get; set; }

        public string Name { get; set; }

        public DateTime StartingHour { get; set; }

        public DateTime EndingHour { get; set; }

        public ICollection<Booking> Bookings { get; set; }

        public PingPongTable CreatePingPongTable()
        {
            var instance = new PingPongTable
            {
                PingPongTableId = Guid.NewGuid(),
                StartingHour = DateTime.UtcNow,
                EndingHour = DateTime.UtcNow,
                Bookings = new HashSet<Booking>()
            };

            return instance;
        }

        public void UpdatePingPongTable(string name, DateTime startingHour, DateTime endingHour, ICollection<Booking> bookings)
        {
            Name = name;
            StartingHour = startingHour;
            EndingHour = endingHour;
            Bookings = bookings;
        }
    }
}
