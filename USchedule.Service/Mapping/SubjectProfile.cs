using AutoMapper;
using USchedule.Domain.Entities;
using USchedule.Service.Models;

namespace USchedule.Service.Mapping
{
    public class SubjectProfile : Profile
    {
        public SubjectProfile()
        {
            CreateMap<SubjectModel, Subject>().ReverseMap();
        }
    }
}
