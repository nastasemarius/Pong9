using Pong9.Data.Entities;
using System;
using System.Collections.Generic;

namespace Pong9.IRepositories
{
    public interface IPingPongTableRepository
    {
        IEnumerable<PingPongTable> GetAllPingPongTables();
        PingPongTable GetPingPongTableById(Guid id);
        void CreatePingPongTable(PingPongTable pingPongTable);
        void EditPingPongTable(PingPongTable pingPongTable);
        void DeletePingPongTable(PingPongTable pingPongTable);
    }
}
