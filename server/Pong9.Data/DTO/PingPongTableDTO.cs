using System;
using System.Collections.Generic;
using System.Text;
using Pong9.Data.Entities;

namespace Pong9.Data.DTO
{
    public class PingPongTableDTO
    {
        public string Name { get; set; }

        public DateTime StartingHour { get; set; }

        public DateTime EndingHour { get; set; }

        public Guid WorkingStateId { get; set; }

        public ICollection<Booking> Bookings { get; set; }

    }
}
