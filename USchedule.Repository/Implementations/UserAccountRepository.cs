using Microsoft.AspNetCore.Identity;
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
    }
}
