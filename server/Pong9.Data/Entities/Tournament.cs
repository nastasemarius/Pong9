using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pong9.Data.Entities
{
    public class Tournament
    {
        [Key] public Guid TournamentId { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Name { get; set; }

        public ICollection<Match> Matches { get; set; }

        public Tournament CreateTournament(string name)
        {
            var instance = new Tournament
            {
                TournamentId = Guid.NewGuid(),
                CreatedAt = DateTime.UtcNow,
                Name = name,
                Matches = new HashSet<Match>()
            };

            return instance;
        }

        public void UpdateTournament(ICollection<Match> matches, DateTime createdAt, string name)
        {
            CreatedAt = createdAt;
            Name = name;
            Matches = matches;
        }
    }
}