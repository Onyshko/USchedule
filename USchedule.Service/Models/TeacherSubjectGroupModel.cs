using System.ComponentModel.DataAnnotations.Schema;

namespace USchedule.Service.Models
{
    public class TeacherSubjectGroupModel : BaseEntityModel
    {
        public Guid TeacherId { get; set; }

        public Guid SubjectId { get; set; }

        public Guid GroupId { get; set; }
    }
}
