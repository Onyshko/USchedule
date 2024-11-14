using System.ComponentModel.DataAnnotations.Schema;

namespace USchedule.Service.Models
{
    public class StudentGroupModel : BaseEntityModel
    {
        public Guid StudentId { get; set; }

        public Guid GroupId { get; set; }
    }
}
