using System.ComponentModel.DataAnnotations;

namespace USchedule.Domain.Entities
{
    public class BaseValueEntity : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public required string Name { get; set; }
    }
}
