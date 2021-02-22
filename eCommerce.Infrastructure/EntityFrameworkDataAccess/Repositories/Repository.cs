using eCommerce.Domain;
using eCommerce.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eCommerce.Infrastructure.EntityFrameworkDataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity, IAggregateRoot
    {
        protected readonly ApiContext _context;
        private readonly DbSet<T> _entities;

        public Repository(ApiContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }
        public async Task Add(T entity)
        {
            if (entity == null) throw new ArgumentNullException("The entity is null.");
            await _entities.AddAsync(entity);
        }

        public async Task<List<T>> FindAll()
        {
            return await _entities.ToListAsync();
        }


        public async Task<T> FindById(Guid id)
        {
            return await _entities.FindAsync(id);
        }

        public virtual async Task Remove(Guid id)
        {
            T entity = await _entities.FindAsync(id);
            _entities.Remove(entity);
        }

        public virtual void Remove(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _entities.Attach(entity);
            }
            _entities.Remove(entity);
        }

        public async Task<int> Update(T entity)
        {
            _entities.Update(entity);
            return await _context.SaveChangesAsync();
        }
    }
}
