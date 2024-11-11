namespace USchedule.Domain.Entities
{
    public class Group : BaseValueEntity
    {
        public ICollection<StudentGroup> StudentGroups { get; set; } = new List<StudentGroup>();

        public ICollection<TeacherSubjectGroup> TeacherSubjectGroups { get; set; } = new List<TeacherSubjectGroup>();
    }
}
