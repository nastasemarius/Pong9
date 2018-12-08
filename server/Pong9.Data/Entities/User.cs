using Pong9.Data.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Pong9.Data.Entities
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Token { get; set; }

        public StatusType Status { get; set; }

        public Guid? WorkSpaceId { get; set; }

        public UserRole Roles { get; set; }

        public DateTime CreatedAt { get; set; }

        public static User CreateUser(string username, string password, string email)
        {
            var instance = new User
            {
                UserId = Guid.NewGuid(),
                Username = username,
                Password = password,
                Email = email,
                Roles = UserRole.Normal,
                Status = StatusType.Offline
            };

            return instance;
        }

        public void UpdateUser(string firstName, string lastName, StatusType status, Guid workSpaceId,
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
