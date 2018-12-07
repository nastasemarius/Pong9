using Pong9.Data.Entities;
using System;
using System.Collections.Generic;

namespace Pong9.IRepositories
{
    public interface IMatchRepository
    {
        IEnumerable<Match> GetAllMatches();
        Match GetMatchById(Guid id);
        void CreateMatch(Match match);
        void EditMatch(Match match);
        void DeleteMatch(Match match);
    }
}
