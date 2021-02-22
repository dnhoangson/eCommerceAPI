using Domain.Users;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IUserFactory _userFactory;

        public UserRepository(IUserFactory userFactory)
        {
            _userFactory = userFactory;
        }

        public Task<User> Add(User entity)
        {
            return Task.FromResult(_userFactory.CreateUserInstance(entity.UserIdentity, entity.UserName, entity.Email));
        }

        public Task<List<User>> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<User> Remove(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
