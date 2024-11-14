using AutoMapper;
using USchedule.Domain.Entities;
using USchedule.Service.Models;

namespace USchedule.Service.Mapping
{
    public class GroupProfile : Profile
    {
        public GroupProfile()
        {
            CreateMap<Group, GroupModel>().ReverseMap();
        }
    }
}
