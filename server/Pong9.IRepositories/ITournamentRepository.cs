using Pong9.Data.Entities;
using System;
using System.Collections.Generic;

namespace Pong9.IRepositories
{
    public interface ITournamentRepository
    {
        IEnumerable<Tournament> GetAllTournaments();
        Tournament GetTournamentById(Guid id);
        void CreateTournament(Tournament tournament);
        void EditTournament(Tournament tournament);
        void DeleteTournament(Tournament tournament);
    }
}
