using AutoMapper;
using USchedule.Domain.Entities;
using USchedule.Repository.Interfaces;
using USchedule.Service.Interfaces;
using USchedule.Service.Models;

namespace USchedule.Service.Implementations
{
    public class BaseCrudService<TEntity, TModel> : IBaseCrudService<TModel>
        where TEntity : BaseEntity
        where TModel : BaseEntityModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BaseCrudService(IUnitOfWork unitOfWork,
                              IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateAsync(TModel model)
        {
            if (model is null)
                throw new NullReferenceException();
            var repository = _unitOfWork.GetRepository<TEntity>();
            var entity = _mapper.Map<TEntity>(model);

            var entityId = await repository.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IList<TModel>> GetAllAsync()
        {
            var repository = _unitOfWork.GetRepository<TEntity>();
            var models = _mapper.Map<List<TModel>>(await repository.GetAllAsync());

            await _unitOfWork.SaveChangesAsync();
            return models;
        }

        public async Task<TModel> GetAsync(Guid id)
        {
            var repository = _unitOfWork.GetRepository<TEntity>();
            var entity = await repository.GetAsync(id);
            var model = _mapper.Map<TModel>(entity);

            await _unitOfWork.SaveChangesAsync();
            return model;
        }

        public async Task UpdateAsync(TModel model)
        {
            var repository = _unitOfWork.GetRepository<TEntity>();
            var entity = await repository.GetAsync((Guid)model.Id!);

            if (entity == null)
            {
                throw new NullReferenceException();
            }

            var newEntity = _mapper.Map<TEntity>(model);

            await repository.UpdateAsync(newEntity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(TModel model)
        {
            var repository = _unitOfWork.GetRepository<TEntity>();
            var entity = await repository.GetAsync((Guid)model.Id!);

            if (entity == null)
            {
                throw new NullReferenceException();
            }

            await repository.DeleteAsync(entity.Id);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
