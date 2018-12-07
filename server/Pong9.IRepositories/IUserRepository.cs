using Pong9.Data.Entities;
using System;
using System.Collections.Generic;

namespace Pong9.IRepositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(Guid id);
        void CreateUser(User user);
        void EditUser(User user);
        void DeleteUser(User user);
    }
}
