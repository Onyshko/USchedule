using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace USchedule.Domain.Entities
{
    public class Entry : BaseEntity
    {
        [ForeignKey("Subject")]
        public Guid SubjectId { get; set; }

        [ForeignKey("Group")]
        public Guid GroupId { get; set; }

        [ForeignKey("Teacher")]
        public Guid TeacherId { get; set; }

        [ForeignKey("Faculty")]
        public Guid? FacultyId { get; set; }

        [Required]
        public DateTime EntryDate { get; set; }

        [Required]
        public TimeSpan EntryTime { get; set; }

        [Required]
        public required string EntryType { get; set; }

        public string? MeetingLink { get; set; }

        public string? RoomNumber { get; set; }

        public string? Notes { get; set; }

        public string? Homework { get; set; }

        public required Subject Subject { get; set; }
        public required Group Group { get; set; }
        public required User Teacher { get; set; }
        public Faculty? Faculty { get; set; }
    }
}
