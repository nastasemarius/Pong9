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
    public class TournamentRepository : ITournamentRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public TournamentRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }


        public IEnumerable<Tournament> GetAllTournaments()
        {
            return _applicationDbContext.Tournaments.ToList();
        }

        public Tournament GetTournamentById(Guid id)
        {
            return _applicationDbContext.Tournaments.Find(id);
        }

        public void CreateTournament(TournamentDTO tournamentDto)
        {
            var tournament = Tournament.CreateTournament();
            tournament.UpdateTournament(tournamentDto.Matches, tournamentDto.Name);
            _applicationDbContext.Tournaments.Add(tournament);
            _applicationDbContext.SaveChanges();
        }

        public void EditTournament(Guid id, TournamentDTO tournament)
        {
            var tournamentToEdit = _applicationDbContext.Tournaments.Find(id);
            tournamentToEdit.UpdateTournament(tournament.Matches, tournament.Name);
            _applicationDbContext.Tournaments.Add(tournamentToEdit);
            _applicationDbContext.SaveChanges();
        }

        public void DeleteTournament(Tournament tournament)
        {
            _applicationDbContext.Tournaments.Remove(tournament);
        }
    }
}
