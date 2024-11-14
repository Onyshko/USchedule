using AutoMapper;
using USchedule.Domain.Entities;
using USchedule.Service.Models;

namespace USchedule.Service.Mapping
{
    public class StudentGroupProfile : Profile
    {
        public StudentGroupProfile()
        {
            CreateMap<StudentGroup, StudentGroupModel>().ReverseMap();
        }
    }
}
