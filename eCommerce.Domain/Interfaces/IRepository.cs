using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eCommerce.Domain.Interfaces
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        Task<T> FindById(Guid id);
        Task<List<T>> FindAll();
        Task Add(T entity);
        Task<int> Update(T entity);
        Task Remove(Guid id);

    }
}
