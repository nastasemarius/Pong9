using Pong9.Data.Entities;
using System;
using System.Collections.Generic;
using Pong9.Data.DTO;

namespace Pong9.IRepositories
{
    public interface IPingPongTableRepository
    {
        IEnumerable<PingPongTable> GetAllPingPongTables();
        PingPongTable GetPingPongTableById(Guid id);
        void CreatePingPongTable(PingPongTableDTO pingPongTableDto);
        void EditPingPongTable(Guid id, PingPongTableDTO pingPongTableDto);
        void DeletePingPongTable(PingPongTable pingPongTable);
    }
}
