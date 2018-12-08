using Pong9.Data.Enums;
using System;
using Pong9.Data.Entities;

namespace Pong9.Data.DTO
{
    public class UserDTO
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public StatusType? Status { get; set; }

        public string WorkSpaceId { get; set; }

        public UserRole? Roles { get; set; }
    }
}
