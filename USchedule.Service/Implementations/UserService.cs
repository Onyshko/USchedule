using AutoMapper;
using Microsoft.AspNetCore.WebUtilities;
using USchedule.Domain.Entities;
using USchedule.Repository.Interfaces;
using USchedule.Repository.Models;
using USchedule.Service.Interfaces;
using USchedule.Service.Models.AccountModels;
using USchedule.Shared.Extensions.Exceptions;

namespace USchedule.Service.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
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

        public async Task RegistrateAsync(UserRegistrationModel userRegistrationModel)
        {
            if (userRegistrationModel is null)
                throw new NullReferenceException();

            var user = _mapper.Map<User>(userRegistrationModel);
            var result = await _unitOfWork.UserAccountRepository().RegisterAsync(user, userRegistrationModel.Password);

            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(e => e.Description);

                throw new IdentityException(errors);
            }

            var emailToken = await _unitOfWork.UserAccountRepository().GenerateEmailConfirmationTokenAsync(user);
            var passwordToken = await _unitOfWork.UserAccountRepository().GeneratePasswordResetTokenAsync(user);
            var param = new Dictionary<string, string?>
            {
                { "emailToken", emailToken },
                { "email", user.Email },
                { "passwordToken", passwordToken }
            };

            var callback = QueryHelpers.AddQueryString(userRegistrationModel.ClientUri!, param);

            var message = new Message
            (
                [user.Email!],
                "Registration. Confirmation of your account in USchedule",
                callback
            );

            await _unitOfWork.EmailSender().SendEmailAsync(message);

            foreach(var role in userRegistrationModel.Roles)
            {
                await _unitOfWork.UserAccountRepository().AddToRoleAsync(user, role);
            }

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task EmailCheckAsync(string email, string token)
        {
            var user = await _unitOfWork.UserAccountRepository().FindByEmailAsync(email);
            if (user is null)
                throw new EmailException();

            var confirmatedResult = await _unitOfWork.UserAccountRepository().ConfirmEmailAsync(user, token);
            if (!confirmatedResult.Succeeded)
                throw new EmailException();

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task ResetPasswordAsync(ResetPasswordModel resetPasswordModel, string passwordToken)
        {
            var errorList = new List<string>();
            var user = await _unitOfWork.UserAccountRepository().FindByEmailAsync(resetPasswordModel.Email!);
            if (user is null)
            {
                errorList.Add("Invalid Request");
                throw new IdentityException(errorList);
            }

            var result = await _unitOfWork.UserAccountRepository().ResetPasswordAsync(user, passwordToken, resetPasswordModel.Password!);
            if (!result.Succeeded)
            {
                result.Errors.ToList().ForEach(error => errorList.Add(error.Description));
                throw new IdentityException(errorList);
            }

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task ForgotPasswordAsync(ForgotPasswordModel forgotPasswordModel)
        {
            var user = await _unitOfWork.UserAccountRepository().FindByEmailAsync(forgotPasswordModel.Email!);
            if (user is null)
                throw new NullReferenceException();

            var token = await _unitOfWork.UserAccountRepository().GeneratePasswordResetTokenAsync(user);
            var param = new Dictionary<string, string?>
            {
                { "token", token },
                { "email", forgotPasswordModel.Email }
            };

            var callback = QueryHelpers.AddQueryString(forgotPasswordModel.ClientUri!, param);

            var message = new Message
            (
                [user.Email!],
                "USchedule. Resetting the password",
                callback
            );

            await _unitOfWork.EmailSender().SendEmailAsync(message);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IList<UserModel>> GetAllUsersAsync()
        {
            var users = _unitOfWork.UserAccountRepository().GetAllUsers().ToList();
            var userModels = _mapper.Map<List<UserModel>>(users);

            await _unitOfWork.SaveChangesAsync();

            return userModels;
        }

        public async Task<UserModel> GetUserAsync(Guid id)
        {
            var user = await _unitOfWork.UserAccountRepository().GetUserAsync(id);
            var userModel = _mapper.Map<UserModel>(user);

            userModel.Roles = (await _unitOfWork.UserAccountRepository().GetRolesAsync(user)).ToList();

            await _unitOfWork.SaveChangesAsync();

            return userModel;
        }

        public async Task UpdateUserAsync(UserModel userModel)
        {
            var user = await _unitOfWork.UserAccountRepository().GetUserAsync(userModel.Id);

            if (user == null)
            {
                throw new NullReferenceException();
            }

            user.Name = userModel.Name!;
            user.Surname = userModel.Surname!;
            user.Email = userModel.Email;

            await _unitOfWork.UserAccountRepository().UpdateAsync(user);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(UserModel userModel)
        {
            var user = await _unitOfWork.UserAccountRepository().GetUserAsync(userModel.Id);

            if (user == null)
            {
                throw new NullReferenceException();
            }

            await _unitOfWork.UserAccountRepository().DeleteAsync(user);

            await _unitOfWork.SaveChangesAsync();
        }
    }
}
