using Microsoft.Extensions.DependencyInjection;
using USchedule.Domain.Entities;
using USchedule.Service.Implementations;
using USchedule.Service.Interfaces;
using USchedule.Service.Models;

namespace USchedule.Service.Utility.Registrations
{
    public static class ServiceRegistration
    {
        public static void AddServiceRegistration(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IJwtService, JwtService>();
            services.AddScoped<IBaseCrudService<SubjectModel>, BaseCrudService<Subject, SubjectModel>>();
            services.AddScoped<IBaseCrudService<GroupModel>, BaseCrudService<Group, GroupModel>>();
            services.AddScoped<IBaseCrudService<TeacherSubjectGroupModel>, BaseCrudService<TeacherSubjectGroup, TeacherSubjectGroupModel>>();
            services.AddScoped<IBaseCrudService<StudentGroupModel>, BaseCrudService<StudentGroup, StudentGroupModel>>();
        }
    }
}
