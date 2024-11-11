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
    }
}
