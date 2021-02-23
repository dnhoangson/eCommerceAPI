using eCommerce.ApplicationCore.Services;
using eCommerce.Domain.Entities.Users;
using System;
using System.Threading.Tasks;

namespace eCommerce.Infrastructure.EntityFrameworkDataAccess.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApiContext _apiContext;
        public IUserRepository UserRepository { get; }

        public UnitOfWork(ApiContext apiContext,
                            IUserRepository userRepository)
        {
            _apiContext = apiContext;
            UserRepository = userRepository;
        }

        public async Task<int> Complete()
        {
            return await _apiContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool state)
        {
            if (state)
            {
                _apiContext.Dispose();
            }
        }
    }
}
