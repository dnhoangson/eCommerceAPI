using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        Task<T> FindById(Guid id);
        Task<List<T>> FindAll();
        Task<T> Add(T entity);
        Task<T> Remove(Guid id);

    }
}
