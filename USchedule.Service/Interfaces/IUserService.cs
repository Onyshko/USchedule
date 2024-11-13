using USchedule.Service.Models.AccountModels;

namespace USchedule.Service.Interfaces
{
    public interface IUserService
    {
        Task CheckOfUserAsync(UserAuthenticationModel userAuthenticationModel);

        Task RegistrateAsync(UserRegistrationModel user);

        Task EmailCheckAsync(string email, string token);

        Task ResetPasswordAsync(ResetPasswordModel resetPasswordModel, string passwordToken);

        Task ForgotPasswordAsync(ForgotPasswordModel forgotPasswordModel);

        Task<IList<UserModel>> GetAllUsersAsync();

        Task<UserModel> GetUserAsync(Guid id);

        Task UpdateUserAsync(UserModel userModel);

        Task DeleteUserAsync(UserModel userModel);
    }
}
