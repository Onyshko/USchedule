using System.ComponentModel.DataAnnotations.Schema;

namespace USchedule.Domain.Entities
{
    public class TeacherSubjectGroup : BaseEntity
    {
        [ForeignKey("User")]
        public Guid TeacherId { get; set; }

        [ForeignKey("Subject")]
        public Guid SubjectId { get; set; }

        [ForeignKey("Group")]
        public Guid GroupId { get; set; }

        public required User Teacher { get; set; }
        public required Subject Subject { get; set; }
        public required Group Group { get; set; }
    }
}
