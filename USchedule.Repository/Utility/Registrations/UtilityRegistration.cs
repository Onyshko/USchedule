using Microsoft.Extensions.DependencyInjection;
using USchedule.Repository.Handlers;
using USchedule.Repository.Implementations;
using USchedule.Repository.Interfaces;

namespace USchedule.Repository.Utility.Registrations
{
    public static class UtilityRegistration
    {
        public static void AddUtilityRegistration(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddSingleton<JwtHandler>();
        }
    }
}
