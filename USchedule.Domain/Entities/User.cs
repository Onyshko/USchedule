using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace USchedule.Domain.Entities
{
    public class User : IdentityUser<Guid>
    {
        [Required]
        [MaxLength(50)]
        public required string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public required string Surname { get; set; }

        [Required]
        public int GroupId { get; set; }

        public ICollection<StudentGroup> StudentGroups { get; set; } = new List<StudentGroup>();

        public ICollection<TeacherSubjectGroup> TeacherSubjectGroups { get; set; } = new List<TeacherSubjectGroup>();
    }
}
