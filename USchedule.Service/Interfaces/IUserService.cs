using USchedule.Service.Models.AccountModels;

namespace USchedule.Service.Interfaces
{
    public interface IUserService
    {
        Task CheckOfUserAsync(UserAuthenticationModel userAuthenticationModel);
    }
}
