using Pong9.Data.Entities;
using System;
using System.Collections.Generic;

namespace Pong9.Data.DTO
{
    public class WorkSpaceDTO
    {
        public string Name { get; set; }

        public string UrlTag { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
