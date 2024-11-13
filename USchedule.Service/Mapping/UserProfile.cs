using AutoMapper;
using USchedule.Domain.Entities;
using USchedule.Service.Models.AccountModels;

namespace USchedule.Service.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserRegistrationModel, User>()
                .ForMember(dest => dest.UserName, opts => opts.MapFrom(src => src.Email));

            CreateMap<User, UserModel>();
        }
    }
}
