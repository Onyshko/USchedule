using Microsoft.AspNetCore.Identity;
using USchedule.Domain.Entities;

namespace USchedule.Repository.Interfaces
{
    public interface IUserAccountRepository
    {
        Task<User> FindByNameAsync(string email);

        Task<bool> IsEmailConfirmed(User user);

        Task<bool> CheckPassword(User user, string password);

        Task<IList<string>> GetRolesAsync(User user);

        Task<User?> FindByEmailAsync(string email);

        Task<IdentityResult> RegisterAsync(User user, string? password = null);

        Task<string> GenerateEmailConfirmationTokenAsync(User user);

        Task<string> GeneratePasswordResetTokenAsync(User user);

        Task<IdentityResult> AddToRoleAsync(User user, string role);

        Task<IdentityResult> ConfirmEmailAsync(User user, string token);

        Task<IdentityResult> ResetPasswordAsync(User user, string token, string password);

        IQueryable<User> GetAllUsers();

        Task<User> GetUserAsync(Guid userId);

        Task<IdentityResult> UpdateAsync(User user);

        Task<IdentityResult> DeleteAsync(User user);
    }
}
