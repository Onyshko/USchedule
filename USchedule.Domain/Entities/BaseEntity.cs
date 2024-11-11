using System.ComponentModel.DataAnnotations;

namespace USchedule.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
