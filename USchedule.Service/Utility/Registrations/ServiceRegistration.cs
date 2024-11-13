using Microsoft.Extensions.DependencyInjection;
using USchedule.Service.Implementations;
using USchedule.Service.Interfaces;

namespace USchedule.Service.Utility.Registrations
{
    public static class ServiceRegistration
    {
        public static void AddServiceRegistration(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IJwtService, JwtService>();
            services.AddScoped<ISubjectService, SubjectService>();
        }
    }
}
