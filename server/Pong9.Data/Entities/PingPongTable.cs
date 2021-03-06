﻿using System;
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

        public Guid WorkSpaceId { get; set; }

        public ICollection<Booking> Bookings { get; set; }

        public static PingPongTable CreatePingPongTable(Guid workSpaceId)
        {
            var instance = new PingPongTable
            {
                PingPongTableId = Guid.NewGuid(),
                StartingHour = DateTime.UtcNow,
                EndingHour = DateTime.UtcNow,
                Bookings = new HashSet<Booking>(),
                WorkSpaceId = workSpaceId
            };

            return instance;
        }

        public void UpdatePingPongTable(string name, ICollection<Booking> bookings, DateTime startingHour,
            DateTime endingHour)
        {
            Name = name;
            StartingHour = startingHour;
            EndingHour = endingHour;
            Bookings = bookings;
        }
    }
}
