using Microsoft.AspNetCore.Identity;
using USchedule.Domain.Entities;
using USchedule.Repository.Context;
using USchedule.Repository.Interfaces;
using USchedule.Repository.Models;

namespace USchedule.Repository.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private Dictionary<Type, object> _repositories;
        private IUserAccountRepository _userAccountRepository;
        private IEmailSender _emailSender;
        private readonly DatabaseContext _context;
        private readonly UserManager<User> _userManager;
        private readonly EmailConfiguration _emailConfig;

        public UnitOfWork(DatabaseContext context,
                          UserManager<User> userManager,
                          EmailConfiguration emailConfig)
        {
            _context = context;
            _repositories = new Dictionary<Type, object>();
            _userManager = userManager;
            _emailConfig = emailConfig;
        }

        public IBaseRepository<TEntity> GetRepository<TEntity>()
            where TEntity : BaseEntity
        {
            if (_repositories.ContainsKey(typeof(TEntity)))
            {
                return (IBaseRepository<TEntity>)_repositories[typeof(TEntity)];
            }

            var repository = new BaseRepository<TEntity>(_context);
            _repositories.Add(typeof(TEntity), repository);
            return repository;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IUserAccountRepository UserAccountRepository() => _userAccountRepository ??= new UserAccountRepository(_userManager);

        public IEmailSender EmailSender() => _emailSender ??= new EmailSender(_emailConfig);
    }
}
