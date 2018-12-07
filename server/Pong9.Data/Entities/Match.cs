using System;
using System.ComponentModel.DataAnnotations;
using Pong9.Data.DTO;
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

        public static Match CreateMatch()
        {
            var instance = new Match
            {
                MatchId = Guid.NewGuid()
            };

            return instance;
        }

        public void UpdateMatch(MatchType type, Guid bookingId, User firstPlayer, User secondPlayer, User firstPlayerTeammate, User secondPlayerTeammate)
        {
            Type = type;
            BookingId = bookingId;
            FirstPlayer = firstPlayer;
            SecondPlayer = secondPlayer;
            FirstPlayerTeammate = firstPlayerTeammate;
            SecondPlayerTeammate = secondPlayerTeammate;
        }
    }
}
