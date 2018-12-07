using System;
using System.ComponentModel.DataAnnotations;
using Pong9.Data.Enums;

namespace Pong9.Data.Entities
{
    public class Match
    {
        [Key]
        public Guid MatchId { get; set; }

        public MatchType Type { get; set; }

        public Guid BookingId { get; set; }

        public User FirstPlayer { get; set; }

        public User SecondPlayer { get; set; }

        public User FirstPlayerTeammate { get; set; }

        public User SecondPlayerTeammate { get; set; }

        public Match CreateMatch()
        {
            var instance = new Match
            {
                MatchId = Guid.NewGuid(),
                BookingId = Guid.NewGuid()
            };

            return instance;
        }
    }
}
