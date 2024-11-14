using Microsoft.Extensions.DependencyInjection;
using USchedule.Service.Mapping;

namespace USchedule.Service.Utility.Registrations
{
    public static class MapperRegistration
    {
        public static void AddMapperRegistration(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(UserProfile).Assembly);
            services.AddAutoMapper(typeof(SubjectProfile).Assembly);
            services.AddAutoMapper(typeof(GroupProfile).Assembly);
            services.AddAutoMapper(typeof(TeacherSubjectGroupProfile).Assembly);
            services.AddAutoMapper(typeof(StudentGroupProfile).Assembly);
        }
    }
}
