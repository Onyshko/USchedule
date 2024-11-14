using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using USchedule.Service.Interfaces;
using USchedule.Service.Models;

namespace USchedule.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IBaseCrudService<GroupModel> _groupService;

        public GroupController(IBaseCrudService<GroupModel> subjectService)
        {
            _groupService = subjectService;
        }

        [HttpPost]
        [Authorize(Policy = "OnlyAdminUsers")]
        public async Task<IActionResult> CreateGroup(GroupModel groupModel)
        {
            await _groupService.CreateAsync(groupModel);

            return Ok("Group has been created.");
        }

        [HttpGet]
        [Authorize(Policy = "OnlyAdminUsers")]
        public async Task<IActionResult> GetAllGroups()
        {
            var groups = await _groupService.GetAllAsync();

            return Ok(groups);
        }

        [HttpGet("{id}")]
        [Authorize(Policy = "OnlyAdminUsers")]
        public async Task<IActionResult> GetGroup(Guid id)
        {
            var group = await _groupService.GetAsync(id);

            return Ok(group);
        }

        [HttpPut]
        [Authorize(Policy = "OnlyAdminUsers")]
        public async Task<IActionResult> UpdateGroup([FromBody] GroupModel groupModel)
        {
            await _groupService.UpdateAsync(groupModel);

            return Ok("Group has been updated.");
        }

        [HttpDelete]
        [Authorize(Policy = "OnlyAdminUsers")]
        public async Task<IActionResult> DeleteGroup([FromBody] GroupModel groupModel)
        {
            await _groupService.DeleteAsync(groupModel);

            return Ok("Group has been deleted.");
        }
    }
}
