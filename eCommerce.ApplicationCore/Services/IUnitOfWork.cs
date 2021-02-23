using eCommerce.Domain.Entities.Users;
using System;
using System.Threading.Tasks;

namespace eCommerce.ApplicationCore.Services
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        Task<int> Complete();
    }
}
