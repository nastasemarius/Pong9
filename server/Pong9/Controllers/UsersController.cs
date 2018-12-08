using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pong9.Api.Models.UserModels;
using Pong9.Data.DTO;
using Pong9.IServices;

namespace Pong9.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("user/[action]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost, ActionName("authenticate")]
        public IActionResult Authenticate([FromBody]UserAuthenticateModel userParam)
        {
            var user = _userService.Authenticate(userParam.Username, userParam.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }

        [AllowAnonymous]
        [HttpPost, ActionName("register")]
        public IActionResult Register([FromBody]UserRegisterModel userModel)
        {
            _userService.Create(userModel.Username, userModel.Email, userModel.Password);
            
            return Ok(userModel.Username);
        }

        [AllowAnonymous]
        [HttpPut, ActionName("settings")]
        public IActionResult UpdateProfile(Guid userId, [FromBody]UserRenameModel userModel)
        {
            var userDto = new UserDTO()
            {
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                Status = userModel.Status
            };

            if (!_userService.UpdateProfile(userId, userDto))
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}