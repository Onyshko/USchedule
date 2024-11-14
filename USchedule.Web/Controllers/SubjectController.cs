using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using USchedule.Service.Interfaces;
using USchedule.Service.Models;

namespace USchedule.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly IBaseCrudService<SubjectModel> _subjectService;

        public SubjectController(IBaseCrudService<SubjectModel> subjectService)
        {
            _subjectService = subjectService;
        }

        [HttpPost]
        [Authorize(Policy = "OnlyAdminUsers")]
        public async Task<IActionResult> CreateSubject(SubjectModel subjectModel)
        {
            await _subjectService.CreateAsync(subjectModel);

            return Ok("Subject has been created.");
        }

        [HttpGet]
        [Authorize(Policy = "OnlyAdminUsers")]
        public async Task<IActionResult> GetAllSubjects()
        {
            var subjects = await _subjectService.GetAllAsync();

            return Ok(subjects);
        }

        [HttpGet("{id}")]
        [Authorize(Policy = "OnlyAdminUsers")]
        public async Task<IActionResult> GetSubject(Guid id)
        {
            var subject = await _subjectService.GetAsync(id);

            return Ok(subject);
        }

        [HttpPut]
        [Authorize(Policy = "OnlyAdminUsers")]
        public async Task<IActionResult> UpdateSubject([FromBody] SubjectModel subjectModel)
        {
            await _subjectService.UpdateAsync(subjectModel);

            return Ok("Subject has been updated.");
        }

        [HttpDelete]
        [Authorize(Policy = "OnlyAdminUsers")]
        public async Task<IActionResult> DeleteSubject([FromBody] SubjectModel subjectModel)
        {
            await _subjectService.DeleteAsync(subjectModel);

            return Ok("Subject has been deleted.");
        }
    }
}
