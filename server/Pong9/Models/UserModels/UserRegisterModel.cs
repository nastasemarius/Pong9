
using System.ComponentModel.DataAnnotations;

namespace Pong9.Api.Models.UserModels
{
    public class UserRegisterModel
    {
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
