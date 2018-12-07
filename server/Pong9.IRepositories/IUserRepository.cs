using Pong9.Data.Entities;
using System;
using System.Collections.Generic;
using Pong9.Data.DTO;

namespace Pong9.IRepositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(Guid id);
        void CreateUser(UserDTO user);
        void EditUser(UserDTO user);
        void DeleteUser(User user);
    }
}
