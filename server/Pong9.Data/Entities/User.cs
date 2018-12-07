using Microsoft.AspNetCore.Identity;
using Pong9.Data.Enums;
using System;

namespace Pong9.Data.Entities
{
    public class User
    {
        public Guid UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Token { get; set; }

        public StatusType Status { get; set; }

        public WorkSpace WorkSpaceId { get; set; }

        public UserRole Roles { get; set; }

        public DateTime CreatedAt { get; set; }

        public void UpdateUser(string firstName, string lastName, StatusType status, WorkSpace workSpaceId,
            UserRole roles)
        {
            FirstName = firstName;
            LastName = lastName;
            Status = status;
            WorkSpaceId = workSpaceId;
            Roles = roles;
        }
    }
}
