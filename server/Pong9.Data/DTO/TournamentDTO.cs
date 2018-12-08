using System;
using System.Collections.Generic;
using System.Text;
using Pong9.Data.Entities;

namespace Pong9.Data.DTO
{
    public class TournamentDTO
    {
        public string Name { get; set; }

        public ICollection<Match> Matches { get; set; }
    }
}
