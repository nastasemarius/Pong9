using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pong9.Api.Models.UserModels
{
    public class UserAuthenticateModel
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
