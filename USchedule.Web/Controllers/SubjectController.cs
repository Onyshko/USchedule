using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace USchedule.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        [HttpGet]
        [Authorize(Policy = "OnlyAdminUsers")]
        public async Task<IActionResult> TestAction()
        {
            return Ok("Test passed!");
        }
    }
}
