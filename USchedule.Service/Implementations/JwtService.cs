using USchedule.Repository.Handlers;
using USchedule.Repository.Interfaces;
using USchedule.Service.Interfaces;

namespace USchedule.Service.Implementations
{
    public class JwtService : IJwtService
    {
        private readonly JwtHandler _jwtHandler;
        private readonly IUnitOfWork _unitOfWork;

        public JwtService(JwtHandler jwtHandler, IUnitOfWork unitOfWork)
        {
            _jwtHandler = jwtHandler;
            _unitOfWork = unitOfWork;
        }

        public async Task<string> CreateToken(string email)
        {
            var user = await _unitOfWork.UserAccountRepository().FindByEmailAsync(email);
            var roles = await _unitOfWork.UserAccountRepository().GetRolesAsync(user!);

            return _jwtHandler.CreateToken(user!, roles);
        }
    }
}
