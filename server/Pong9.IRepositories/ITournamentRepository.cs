using Pong9.Data.Entities;
using System;
using System.Collections.Generic;
using Pong9.Data.DTO;

namespace Pong9.IRepositories
{
    public interface ITournamentRepository
    {
        IEnumerable<Tournament> GetAllTournaments();
        Tournament GetTournamentById(Guid id);
        void CreateTournament(TournamentDTO tournament);
        void EditTournament(Guid id, TournamentDTO tournament);
        void DeleteTournament(Tournament tournament);
    }
}
