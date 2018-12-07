using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pong9.Api.Models.UserModels;
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
        [HttpPost]
        public IActionResult Authenticate([FromBody]UserAuthenticateModel userParam)
        {
            var user = _userService.Authenticate(userParam.Username, userParam.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Register([FromBody]UserRegisterModel userModel)
        {
            _userService.Create(userModel.Username, userModel.Email, userModel.Password);
            
            return Ok();
        }
    }
}