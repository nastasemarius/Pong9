using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Pong9.Data.Entities;
using Pong9.IRepositories;
using Pong9.IServices;
using Pong9.Api.Helpers;
using Pong9.Data.DTO;
using Pong9.Helpers;
using Pong9.Services.Helpers;

namespace Pong9.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly AppSettings _appSettings;
        private readonly HashingAlg _hashAlg;
        private List<User> _users;

        public UserService(IOptions<AppSettings> appSettings, IUserRepository userRepository)
        {
            _appSettings = appSettings.Value;
            _userRepository = userRepository;
            _users = userRepository.GetAllUsers().ToList();
            _hashAlg = new HashingAlg();
        }

        public User Authenticate(string username, string password)
        {
            var hashedPassword = _hashAlg.HashPassword(password);
            var user = _users.SingleOrDefault(x => x.Username == username && x.Password == hashedPassword);

            // return null if user not found
            if (user == null)
                return null;

            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.UserId.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            return user;
        }

        public void Create(string username, string email, string password)
        {
            var userDto = new UserDTO()
            {
                Username = username,
                Email = email,
                Password = _hashAlg.HashPassword(password)
            };

            _userRepository.CreateUser(userDto);
        }

        public bool UpdateProfile(Guid userId, UserDTO userDto)
        {
            var user = _userRepository.GetUserById(userId);

            if (user == null)
            {
                return false;
            }

            _userRepository.EditUser(userId, userDto);

            return true;
        }
    }
}
