using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using USchedule.Domain.Entities;
using USchedule.Shared.Models;

namespace USchedule.Repository.Utility.SeedConfiguration
{
    public static class DataInitializer
    {
        public static async Task InitializeRolesAndSuperAdmin(IServiceProvider services)
        {
            var roleManager = services.GetRequiredService<RoleManager<Role>>();
            var userManager = services.GetRequiredService<UserManager<User>>();

            var roles = new Dictionary<string, string>
            {
                { "SuperAdmin",  "SuperAdmin has all rights to manage the system"},
                { "Admin", "Admins have rights to manage Teachers, GroupLeaders, Students, Groups, Subjects, Entries" }, 
                { "Teacher", "Teachers have rights to manage Entries that related to their subjects and groups" },
                { "GroupLeader", "GroupLeaders have rights to manage Entries of their groups" },
                { "Student", "Students has rights to view Entries of their groups" }
            };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role.Key))
                {
                    await roleManager.CreateAsync(
                        new Role 
                        { 
                            Name = role.Key,  
                            Description = role.Value 
                        }
                    );
                }
            }

            var superAdminModel = services.GetRequiredService<SuperAdminModel>();

            string superAdminEmail = superAdminModel.Email!;
            string superAdminPassword = superAdminModel.Password!;

            if (await userManager.FindByEmailAsync(superAdminEmail) == null)
            {
                var superAdmin = new User
                {
                    Name = "SUPERADMIN",
                    Surname = "SUPERADMIN",
                    Email = superAdminEmail,
                    EmailConfirmed = true,
                    UserName = "SUPERADMIN"
                };

                var result = await userManager.CreateAsync(superAdmin, superAdminPassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(superAdmin, "SuperAdmin");
                }
            }
        }
    }
}
