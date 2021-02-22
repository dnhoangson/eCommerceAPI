using eCommerce.Domain.Users;
using System;
using System.Threading.Tasks;

namespace eCommerce.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        Task<int> Complete();
    }
}
