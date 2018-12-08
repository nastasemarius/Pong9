using System;
using Pong9.Data.DTO;
using Pong9.Data.Entities;
using Pong9.Services.Helpers;

namespace Pong9.IServices
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        void Create(string username, string email, string password);
        bool UpdateProfile(Guid userId, UserDTO userDto);
    }
}
