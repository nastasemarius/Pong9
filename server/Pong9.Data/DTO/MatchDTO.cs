using System;
using System.Collections.Generic;
using System.Text;
using Pong9.Data.Entities;
using Pong9.Data.Enums;

namespace Pong9.Data.DTO
{
    public class MatchDTO
    {
        public MatchType Type { get; set; }

        public Guid BookingId { get; set; }

        public User FirstPlayer { get; set; }

        public User SecondPlayer { get; set; }

        public User FirstPlayerTeammate { get; set; }

        public User SecondPlayerTeammate { get; set; }
    }
}
