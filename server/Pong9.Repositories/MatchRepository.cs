using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pong9.Data.DTO;
using Pong9.Data.Entities;
using Pong9.IRepositories;
using Pong9.Persistence;

namespace Pong9.Repositories
{
    public class MatchRepository : IMatchRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public MatchRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IEnumerable<Match> GetAllMatches()
        {
            return _applicationDbContext.Matches.ToList();
        }

        public Match GetMatchById(Guid id)
        {
            return _applicationDbContext.Matches.SingleOrDefault(m => m.MatchId == id);
        }

        public void CreateMatch(MatchDTO matchDto)
        {
            var match = Match.CreateMatch();
            match.UpdateMatch(matchDto.Type, matchDto.BookingId, matchDto.FirstPlayer, matchDto.SecondPlayer, matchDto.FirstPlayerTeammate, matchDto.SecondPlayerTeammate);

            _applicationDbContext.Matches.Add(match);
            _applicationDbContext.SaveChanges();
        }

        public void EditMatch(Guid id, MatchDTO match)
        {
            var matchToEdit = _applicationDbContext.Matches.Find(id);
            matchToEdit.UpdateMatch(match.Type, match.BookingId, match.FirstPlayer, match.SecondPlayer, match.FirstPlayerTeammate, match.SecondPlayerTeammate);

            _applicationDbContext.Matches.Update(matchToEdit);
            _applicationDbContext.SaveChanges();
        }

        public void DeleteMatch(Match match)
        {
            _applicationDbContext.Matches.Remove(match);
            _applicationDbContext.SaveChanges();
        }
    }
}
