namespace USchedule.Domain.Entities
{
    public class Subject : BaseValueEntity
    {
        public ICollection<TeacherSubjectGroup> TeacherSubjectGroups { get; set; } = new List<TeacherSubjectGroup>();

        public ICollection<Entry> Entries { get; set; } = new List<Entry>();
    }
}
