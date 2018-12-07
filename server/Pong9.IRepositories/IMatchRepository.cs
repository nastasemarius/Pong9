using System;
using System.Collections;
using System.Collections.Generic;
using Pong9.Data.DTO;
using Pong9.Data.Entities;

namespace Pong9.IRepositories
{
    public interface IMatchRepository
    {
        IEnumerable<Match> GetAllMatches();
        Match GetMatchById(Guid id);
        void CreateMatch(MatchDTO match);
        void EditMatch(Guid id, MatchDTO match);
        void DeleteMatch(Match match);
    }
}
