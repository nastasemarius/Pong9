using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pong9.Data.Entities
{
    public class Tournament
    {
        [Key]
        public Guid TournamentId { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Name { get; set; }

        public ICollection<Match> Matches { get; set; }

        public static Tournament CreateTournament()
        {
            var instance = new Tournament
            {
                TournamentId = Guid.NewGuid(),
                CreatedAt = DateTime.UtcNow,
                Matches = new HashSet<Match>()
            };

            return instance;
        }

        public void UpdateTournament(ICollection<Match> matches, string name)
        {
            Name = name;
            Matches = matches;
        }
    }
}