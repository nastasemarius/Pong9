﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Pong9.Data.Entities
{
    public class Invite
    {
        [Key]
        public Guid InviteId { get; set; }

        public DateTime CreatedAt { get; set; }

        public User Source { get; set; }
        public User Destination { get; set; }

        public Booking Booking { get; set; }

        public static Invite CreateInvite()
        {
            var instance = new Invite
            {
                InviteId = Guid.NewGuid(),
                CreatedAt = DateTime.UtcNow
            };

            return instance;
        }

        public void UpdateInvite(User source, User destination, Booking booking)
        {
            Source = source;
            Destination = destination;
            Booking = booking;
        }
    }

}
