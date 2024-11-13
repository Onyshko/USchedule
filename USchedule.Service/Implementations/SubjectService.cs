using AutoMapper;
using USchedule.Domain.Entities;
using USchedule.Repository.Interfaces;
using USchedule.Service.Interfaces;
using USchedule.Service.Models;

namespace USchedule.Service.Implementations
{
    public class SubjectService : ISubjectService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SubjectService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateSubjectAsync(SubjectModel subjectModel)
        {
            if (subjectModel is null)
                throw new NullReferenceException();
            var subjectRepository = _unitOfWork.GetRepository<Subject>();
            var entity = _mapper.Map<Subject>(subjectModel);

            var subjectId = await subjectRepository.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IList<SubjectModel>> GetAllSubjectAsync()
        {
            var subjectRepository = _unitOfWork.GetRepository<Subject>();
            var subjectModels = _mapper.Map<List<SubjectModel>>(await subjectRepository.GetAllAsync());

            await _unitOfWork.SaveChangesAsync();
            return subjectModels;
        }

        public async Task<SubjectModel> GetSubjectAsync(Guid subjectId)
        {
            var subjectRepository = _unitOfWork.GetRepository<Subject>();
            var subject = await subjectRepository.GetAsync(subjectId);
            var subjectModel = _mapper.Map<SubjectModel>(subject);

            await _unitOfWork.SaveChangesAsync();
            return subjectModel;
        }

        public async Task UpdateSubjectAsync(SubjectModel subjectModel)
        {
            var subjectRepository = _unitOfWork.GetRepository<Subject>();
            var subject = await subjectRepository.GetAsync((Guid)subjectModel.Id!);

            if (subject == null)
            {
                throw new NullReferenceException();
            }

            subject.Name = subjectModel.Name;

            await subjectRepository.UpdateAsync(subject);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteSubjectAsync(SubjectModel subjectModel)
        {
            var subjectRepository = _unitOfWork.GetRepository<Subject>();
            var subject = await subjectRepository.GetAsync((Guid)subjectModel.Id!);

            if (subject == null)
            {
                throw new NullReferenceException();
            }
            
            await subjectRepository.DeleteAsync(subject.Id);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
