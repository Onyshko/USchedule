using USchedule.Repository.Interfaces;
using USchedule.Service.Interfaces;
using USchedule.Service.Models.AccountModels;
using USchedule.Shared.Extensions.Exceptions;

namespace USchedule.Service.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CheckOfUserAsync(UserAuthenticationModel userAuthenticationModel)
        {
            var user = await _unitOfWork.UserAccountRepository().FindByEmailAsync(userAuthenticationModel.Email!);
            if (user is null)
                throw new NullReferenceException();

            if (!await _unitOfWork.UserAccountRepository().IsEmailConfirmed(user))
                throw new AuthenticateException("Email is not confirmed");

            if (!await _unitOfWork.UserAccountRepository().CheckPassword(user, userAuthenticationModel.Password!))
                throw new AuthenticateException("Invalid Authentication");

            await _unitOfWork.SaveChangesAsync();
        }
    }
}
