using System.ComponentModel.DataAnnotations;

namespace USchedule.Domain.Entities
{
    public class Faculty : BaseValueEntity
    {
        [Required]
        [MaxLength(100)]
        public required string Address { get; set; }

        public ICollection<Entry> Entries { get; set; } = new List<Entry>();
    }
}
