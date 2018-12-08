
using System;

namespace Pong9.Api.Models.WorkSpaceModels
{
    public class WorkSpaceCreateModel
    {
        public string Name { get; set; }

        public Guid UserId { get; set; }

        public int NumberOfTables { get; set; }
    }
}
