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
    }
}
