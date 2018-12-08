using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Pong9.Api.Models.UserModels;
using Pong9.Data.DTO;
using Pong9.IServices;

namespace Pong9.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("user/[action]")]
    [EnableCors("MyPolicy")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [Produces("application/json")]
        [HttpPost, ActionName("authenticate")]
        public IActionResult Authenticate([FromBody]UserAuthenticateModel userParam)
        {
            var user = _userService.Authenticate(userParam.Username, userParam.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user.Token);
        }

        [AllowAnonymous]
        [HttpPost, ActionName("register")]
        public IActionResult Register([FromBody]UserRegisterModel userModel)
        {
            _userService.Create(userModel.Username, userModel.Email, userModel.Password);
            
            return Ok(_userService.GetUserByUsername(userModel.Username).UserId);
        }

        [HttpPatch, ActionName("changeStatus")]
        public IActionResult UpdateStatus(Guid userId, int statusType)
        {
            if (!_userService.UpdateStatus(userId, statusType))
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpPut, ActionName("updateProfile")]
        public IActionResult UpdateProfile(Guid userId, [FromBody]UserRenameModel userModel)
        {
            var userDto = new UserDTO()
            {
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                Email = userModel.Email
            };

            if (!_userService.UpdateProfile(userId, userDto))
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpPost, ActionName("delete")]
        public IActionResult Delete(Guid userId)
        {
            if (!_userService.DeleteUser(userId))
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}