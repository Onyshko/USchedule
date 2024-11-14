using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using USchedule.Domain.Entities;
using USchedule.Service.Interfaces;
using USchedule.Service.Models;

namespace USchedule.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherSubjectGroupController : ControllerBase
    {
        private readonly IBaseCrudService<TeacherSubjectGroupModel> _teacherSubjectGroupService;

        public TeacherSubjectGroupController(IBaseCrudService<TeacherSubjectGroupModel> teacherSubjectGroupService)
        {
            _teacherSubjectGroupService = teacherSubjectGroupService;
        }

        [HttpPost]
        [Authorize(Policy = "OnlyAdminUsers")]
        public async Task<IActionResult> CreateTeacherSubjectGroup(TeacherSubjectGroupModel teacherSubjectGroupModel)
        {
            await _teacherSubjectGroupService.CreateAsync(teacherSubjectGroupModel);

            return Ok("Teacher-Subject-Group has been created.");
        }

        [HttpGet]
        [Authorize(Policy = "OnlyAdminUsers")]
        public async Task<IActionResult> GetAllTeacherSubjectGroups()
        {
            var teacherSubjectGroups = await _teacherSubjectGroupService.GetAllAsync();

            return Ok(teacherSubjectGroups);
        }

        [HttpGet("{id}")]
        [Authorize(Policy = "OnlyAdminUsers")]
        public async Task<IActionResult> GetTeacherSubjectGroup(Guid id)
        {
            var teacherSubjectGroup = await _teacherSubjectGroupService.GetAsync(id);

            return Ok(teacherSubjectGroup);
        }

        [HttpPut]
        [Authorize(Policy = "OnlyAdminUsers")]
        public async Task<IActionResult> UpdateTeacherSubjectGroup([FromBody] TeacherSubjectGroupModel teacherSubjectGroupModel)
        {
            await _teacherSubjectGroupService.UpdateAsync(teacherSubjectGroupModel);

            return Ok("Teacher-Subject-Group has been updated.");
        }

        [HttpDelete]
        [Authorize(Policy = "OnlyAdminUsers")]
        public async Task<IActionResult> DeleteTeacherSubjectGroup([FromBody] TeacherSubjectGroupModel teacherSubjectGroupModel)
        {
            await _teacherSubjectGroupService.DeleteAsync(teacherSubjectGroupModel);

            return Ok("Teacher-Subject-Group has been deleted.");
        }
    }
}
