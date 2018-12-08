using System;
using System.Collections.Generic;
using System.Text;
using Pong9.Data.Entities;

namespace Pong9.Data.DTO
{
    public class InviteDTO
    {
        public User Source { get; set; }

        public User Destination { get; set; }

        public Booking Booking { get; set; }
    }
}
