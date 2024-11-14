using AutoMapper;
using USchedule.Domain.Entities;
using USchedule.Service.Implementations;
using USchedule.Service.Models;

namespace USchedule.Service.Mapping
{
    public class TeacherSubjectGroupProfile : Profile
    {
        public TeacherSubjectGroupProfile()
        {
            CreateMap<TeacherSubjectGroup, TeacherSubjectGroupModel>().ReverseMap();
        }
    }
}
