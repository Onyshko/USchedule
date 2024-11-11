using Microsoft.AspNetCore.Identity;

namespace USchedule.Domain.Entities
{
    public class Role : IdentityRole<Guid>
    {
        public string? Description { get; set; }

        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
