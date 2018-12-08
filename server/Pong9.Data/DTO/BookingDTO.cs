using System;
using System.Collections.Generic;
using System.Text;
using Pong9.Data.Entities;

namespace Pong9.Data.DTO
{
    public class BookingDTO
    {
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public Guid CreatorId { get; set; }

        public Guid TableId { get; set; }

        public ICollection<User> Players { get; set; }
    }
}
