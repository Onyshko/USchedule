using System.Linq.Expressions;

namespace USchedule.Repository.Interfaces
{
    public interface IBaseRepository<TEntity>
        where TEntity : class
    {
        Task<IList<TEntity>> GetAllAsync(params Expression<Func<TEntity, object>>[] includeProperties);
        Task<TEntity> GetAsync(Guid id, params Expression<Func<TEntity, object>>[] includeProperties);
        Task<Guid> AddAsync(TEntity entity);
        Task<TEntity?> UpdateAsync(TEntity entity);
        Task<bool> DeleteAsync(Guid id);
    }
}
