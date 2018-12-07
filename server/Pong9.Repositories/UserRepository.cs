using Pong9.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pong9.Data.DTO;
using Pong9.Data.Entities;
using Pong9.Persistence;

namespace Pong9.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public UserRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _applicationDbContext.Users.ToList();
        }

        public User GetUserById(Guid id)
        {
            return _applicationDbContext.Users.SingleOrDefault(user => user.UserId == id);
        }

        public void CreateUser(UserDTO userDto)
        {
            var user = User.CreateUser(userDto.Username, userDto.Password, userDto.Email);

            _applicationDbContext.Users.Add(user);
            _applicationDbContext.SaveChanges();
        }

        public void EditUser(UserDTO user)
        {
            //
        }

        public void DeleteUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
