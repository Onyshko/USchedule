using USchedule.Service.Models;

namespace USchedule.Service.Interfaces
{
    public interface IBaseCrudService<TModel>
        where TModel : BaseEntityModel
    {
        Task CreateAsync(TModel model);

        Task<IList<TModel>> GetAllAsync();

        Task<TModel> GetAsync(Guid id);

        Task UpdateAsync(TModel model);

        Task DeleteAsync(TModel model);
    }
}
