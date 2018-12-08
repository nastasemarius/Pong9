using Pong9.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public User GetUserByUsername(string username)
        {

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

        public void EditUser(Guid userId, UserDTO userDto)
        {
            var user = _applicationDbContext.Users.SingleOrDefault(us => us.UserId == userId);
            var modifiedUser = ModifyUser(user, userDto);

            _applicationDbContext.Users.Update(modifiedUser);
            _applicationDbContext.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            _applicationDbContext.Users.Remove(user);
            _applicationDbContext.SaveChanges();
        }

        private User ModifyUser(User user, UserDTO userDto)
        {
            Guid workSpaceId;

            if (userDto.FirstName != user.FirstName)
            {
                user.FirstName = userDto.FirstName;
            }

            if (userDto.LastName != user.LastName)
            {
                user.LastName = userDto.LastName;
            }

            if (userDto.Email != user.Email)
            {
                user.Email = userDto.Email;
            }

            if (userDto.Status != user.Status)
            {
                user.Status = userDto.Status;
            }

            if (Guid.TryParse(userDto.WorkSpaceId, out workSpaceId))
            {
                if (workSpaceId != user.WorkSpaceId)
                {
                    user.WorkSpaceId = workSpaceId;
                }
            }

            if (userDto.Roles != user.Roles)
            {
                user.Roles = userDto.Roles;
            }

            return user;
        }
    }
}
