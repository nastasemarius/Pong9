using Microsoft.AspNetCore.Identity;
using Pong9.Data.Enums;
using System;

namespace Pong9.Data.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public StatusType Status { get; set; }

        public WorkSpace WorkSpaceId { get; set; }

        public UserRole Roles { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
