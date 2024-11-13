using Microsoft.Extensions.DependencyInjection;
using USchedule.Service.Mapping;

namespace USchedule.Service.Utility.Registrations
{
    public static class MapperRegistration
    {
        public static void AddMapperRegistration(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(UserProfile).Assembly);
        }
    }
}
