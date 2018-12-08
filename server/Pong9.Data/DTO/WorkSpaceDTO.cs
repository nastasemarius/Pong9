using System;
using Pong9.Data.Entities;
using System.Collections.Generic;

namespace Pong9.Data.DTO
{
    public class WorkSpaceDTO
    {
        public string Name { get; set; }

        public int NumberOfTables { get; set; }

        public Guid UserId { get; set; }

        public ICollection<User> Users { get; set; }

        public ICollection<PingPongTable> Tables { get; set; }
    }
}
