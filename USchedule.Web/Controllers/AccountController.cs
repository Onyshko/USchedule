using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using USchedule.Service.Interfaces;
using USchedule.Service.Models;
using USchedule.Service.Models.AccountModels;

namespace USchedule.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IJwtService _jwtService;

        public AccountController(IUserService userService, IJwtService jwtService)
        {
            _userService = userService;
            _jwtService = jwtService;
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] UserAuthenticationModel userAuthenticationModel)
        {
            await _userService.CheckOfUserAsync(userAuthenticationModel);
            var token = await _jwtService.CreateToken(userAuthenticationModel.Email);
            return Ok(new AuthenticationResponsModel { IsAuthSuccessful = true, Token = token });
        }

        [HttpPost("register")]
        [Authorize(Policy = "OnlyAdminUsers")]
        public async Task<IActionResult> RegisterUser([FromBody] UserRegistrationModel userRegistrationModel)
        {
            await _userService.RegistrateAsync(userRegistrationModel);
            return StatusCode(201);
        }


        [HttpPost("userconfirmation")]
        public async Task<IActionResult> UserConfirmation([FromQuery] string email,
                                                          [FromQuery] string emailToken,
                                                          [FromQuery] string passwordToken,
                                                          [FromBody] ResetPasswordModel resetPasswordModel)
        {
            if (!ModelState.IsValid)
                throw new Exception();

            await _userService.EmailCheckAsync(email, emailToken);
            await _userService.ResetPasswordAsync(resetPasswordModel, passwordToken);
            return Ok("User has been confirmed.");
        }

        [HttpPost("forgotpassword")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordModel forgotPasswordModel)
        {
            if (!ModelState.IsValid)
                throw new Exception();

            await _userService.ForgotPasswordAsync(forgotPasswordModel);
            return Ok();
        }

        [HttpPost("resetpassword")]
        public async Task<IActionResult> ResetPassword([FromQuery] string passwordToken,
                                                       [FromBody] ResetPasswordModel resetPasswordModel)
        {
            if (!ModelState.IsValid)
                throw new Exception();

            await _userService.ResetPasswordAsync(resetPasswordModel, passwordToken);
            return Ok("Password has been recreated.");
        }

        [HttpGet("users")]
        [Authorize(Policy = "OnlyAdminUsers")]
        public IActionResult GetAllUsers()
        {
            var users = _userService.GetAllUsersAsync();
            return Ok(users);
        }

        [HttpGet("users/{id}")]
        [Authorize(Policy = "OnlyAdminUsers")]
        public async Task<IActionResult> GetUser(Guid id)
        {
            var user = await _userService.GetUserAsync(id);

            return Ok(user);
        }

        [HttpPut("users")]
        [Authorize]
        public async Task<IActionResult> UpdateUser([FromBody] UserModel userModel)
        {
            await _userService.UpdateUserAsync(userModel);

            return Ok("User has been updated.");
        }

        [HttpDelete]
        [Authorize]
        public async Task<IActionResult> DeleteUser([FromBody] UserModel userModel)
        {
            await _userService.DeleteUserAsync(userModel);

            return Ok("User has been deleted.");
        }
    }
}
