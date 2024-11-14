using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using USchedule.Service.Interfaces;
using USchedule.Service.Models;

namespace USchedule.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentGroupController : ControllerBase
    {
        private readonly IBaseCrudService<StudentGroupModel> _studentGroupService;

        public StudentGroupController(IBaseCrudService<StudentGroupModel> studentGroupService)
        {
            _studentGroupService = studentGroupService;
        }

        [HttpPost]
        [Authorize(Policy = "OnlyAdminUsers")]
        public async Task<IActionResult> CreateGroup(StudentGroupModel studentGroupModel)
        {
            await _studentGroupService.CreateAsync(studentGroupModel);

            return Ok("Student-Group has been created.");
        }

        [HttpGet]
        [Authorize(Policy = "OnlyAdminUsers")]
        public async Task<IActionResult> GetAllGroups()
        {
            var studentGroups = await _studentGroupService.GetAllAsync();

            return Ok(studentGroups);
        }

        [HttpGet("{id}")]
        [Authorize(Policy = "OnlyAdminUsers")]
        public async Task<IActionResult> GetGroup(Guid id)
        {
            var studentGroup = await _studentGroupService.GetAsync(id);

            return Ok(studentGroup);
        }

        [HttpPut]
        [Authorize(Policy = "OnlyAdminUsers")]
        public async Task<IActionResult> UpdateGroup([FromBody] StudentGroupModel studentGroupModel)
        {
            await _studentGroupService.UpdateAsync(studentGroupModel);

            return Ok("Student-Group has been updated.");
        }

        [HttpDelete]
        [Authorize(Policy = "OnlyAdminUsers")]
        public async Task<IActionResult> DeleteGroup([FromBody] StudentGroupModel studentGroupModel)
        {
            await _studentGroupService.DeleteAsync(studentGroupModel);

            return Ok("Student-Group has been deleted.");
        }
    }
}
