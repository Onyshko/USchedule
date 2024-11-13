using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using USchedule.Domain.Entities;
using USchedule.Repository.Interfaces;

namespace USchedule.Repository.Implementations
{
    public class UserAccountRepository : IUserAccountRepository
    {
        private readonly UserManager<User> _userManager;

        public UserAccountRepository(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<User> FindByNameAsync(string userName)
        {
            return (await _userManager.FindByNameAsync(userName))!;
        }

        public async Task<bool> IsEmailConfirmed(User user)
        {
            return await _userManager.IsEmailConfirmedAsync(user);
        }

        public async Task<bool> CheckPassword(User user, string password)
        {
            return await _userManager.CheckPasswordAsync(user, password);
        }

        public async Task<IList<string>> GetRolesAsync(User user)
        {
            return await _userManager.GetRolesAsync(user);
        }

        public async Task<User?> FindByEmailAsync(string email)
        {
            return await _userManager.FindByEmailAsync(email);
        }

        public async Task<IdentityResult> RegisterAsync(User user, string? password = null)
        {
            if (password is null)
            {
                return await _userManager.CreateAsync(user);
            }
            else
            {
                return await _userManager.CreateAsync(user, password!);
            }
        }

        public async Task<string> GenerateEmailConfirmationTokenAsync(User user)
        {
            return await _userManager.GenerateEmailConfirmationTokenAsync(user);
        }

        public async Task<string> GeneratePasswordResetTokenAsync(User user)
        {
            return await _userManager.GeneratePasswordResetTokenAsync(user);
        }

        public async Task<IdentityResult> AddToRoleAsync(User user, string role)
        {
            return await _userManager.AddToRoleAsync(user, role);
        }

        public async Task<IdentityResult> ConfirmEmailAsync(User user, string token)
        {
            return await _userManager.ConfirmEmailAsync(user, token);
        }

        public async Task<IdentityResult> ResetPasswordAsync(User user, string token, string password)
        {
            return await _userManager.ResetPasswordAsync(user, token, password);
        }

        public IQueryable<User> GetAllUsers()
        {
            return _userManager.Users;
        }

        public async Task<User> GetUserAsync(Guid userId)
        {
            return (await _userManager.FindByIdAsync(userId.ToString()))!;
        }

        public async Task<IdentityResult> UpdateAsync(User user)
        {
            return await _userManager.UpdateAsync(user);
        }

        public async Task<IdentityResult> DeleteAsync(User user)
        {
            return await _userManager.DeleteAsync(user);
        }
    }
}
