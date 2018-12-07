using System;
using System.Collections.Generic;
using System.Text;
using Pong9.Data.Entities;
using Pong9.Data.Enums;

namespace Pong9.Data.DTO
{
    public class UserDTO
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public StatusType Status { get; set; }

        public WorkSpace WorkSpaceId { get; set; }

        public UserRole Roles { get; set; }
    }
}
