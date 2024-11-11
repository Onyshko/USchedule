using Microsoft.Extensions.DependencyInjection;
using USchedule.Repository.Implementations;
using USchedule.Repository.Interfaces;

namespace USchedule.Repository.Utility.Registrations
{
    public static class RepositoryRegistration
    {
        public static void AddRepositoryRegistration(this IServiceCollection services)
        {
            services.AddScoped<IUserAccountRepository, UserAccountRepository>();
        }
    }
}
