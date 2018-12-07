using System;
using System.Collections.Generic;
using System.Text;
using Pong9.Data.Entities;

namespace Pong9.IServices
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        void Create(string username, string email, string password);
    }
}
