using eCommerce.Domain.Users;

namespace eCommerce.Infrastructure.EntityFrameworkDataAccess.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ApiContext context) : base(context)
        {
        }
    }
}
