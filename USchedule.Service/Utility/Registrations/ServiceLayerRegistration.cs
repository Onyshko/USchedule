using Microsoft.Extensions.DependencyInjection;

namespace USchedule.Service.Utility.Registrations
{
    public static class ServiceLayerRegistration
    {
        public static void AddServiceLayerRegistration(this IServiceCollection services)
        {
            services.AddServiceRegistration();
            services.AddMapperRegistration();
        }
    }
}
