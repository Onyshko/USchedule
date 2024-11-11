using System.ComponentModel.DataAnnotations.Schema;

namespace USchedule.Domain.Entities
{
    public class StudentGroup : BaseEntity
    {
        [ForeignKey("User")]
        public Guid StudentId { get; set; }


        [ForeignKey("Group")]
        public Guid GroupId { get; set; }

        public required User Student { get; set; }
        public required Group Group { get; set; }
    }
}
