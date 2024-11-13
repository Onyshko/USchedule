using USchedule.Domain.Entities;

namespace USchedule.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<TEntity> GetRepository<TEntity>()
            where TEntity : BaseEntity;

        Task SaveChangesAsync();

        IUserAccountRepository UserAccountRepository();

        IEmailSender EmailSender();
    }
}
