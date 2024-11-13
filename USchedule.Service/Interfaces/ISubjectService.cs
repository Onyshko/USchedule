using USchedule.Service.Models;

namespace USchedule.Service.Interfaces
{
    public interface ISubjectService
    {
        Task CreateSubjectAsync(SubjectModel subjectModel);
        Task<IList<SubjectModel>> GetAllSubjectAsync();
        Task<SubjectModel> GetSubjectAsync(Guid subjectId);
        Task UpdateSubjectAsync(SubjectModel subjectModel);
        Task DeleteSubjectAsync(SubjectModel subjectModel);
    }
}
