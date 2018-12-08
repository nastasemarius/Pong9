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
    public class PingPongTableRepository : IPingPongTableRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public PingPongTableRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IEnumerable<PingPongTable> GetAllPingPongTables()
        {
            return _applicationDbContext.PingPongTables.ToList();
        }

        public PingPongTable GetPingPongTableById(Guid id)
        {
            return _applicationDbContext.PingPongTables.SingleOrDefault(ppt => ppt.PingPongTableId == id);
        }

        public void CreatePingPongTable(PingPongTableDTO pingPongTableDto)
        {
            var pingPongTable = PingPongTable.CreatePingPongTable(pingPongTableDto.WorkingStateId);
            pingPongTable.UpdatePingPongTable(pingPongTableDto.Name, pingPongTableDto.Bookings, pingPongTableDto.StartingHour, pingPongTableDto.EndingHour);

            _applicationDbContext.PingPongTables.Add(pingPongTable);
            _applicationDbContext.SaveChanges();
        }

        public void EditPingPongTable(Guid id, PingPongTableDTO pingPongTableDto)
        {
            var pingPongTableToEdit = _applicationDbContext.PingPongTables.Find(id);
            pingPongTableToEdit.UpdatePingPongTable(pingPongTableDto.Name, pingPongTableDto.Bookings, pingPongTableDto.StartingHour, pingPongTableDto.EndingHour);

            _applicationDbContext.PingPongTables.Update(pingPongTableToEdit);
            _applicationDbContext.SaveChanges();
        }

        public void DeletePingPongTable(PingPongTable pingPongTable)
        {
            _applicationDbContext.PingPongTables.Remove(pingPongTable);
            _applicationDbContext.SaveChanges();
        }
    }
}
