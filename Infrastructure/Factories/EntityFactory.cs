using Domain.Users;
using Domain.Users.ValueObjects;
using System.Threading.Tasks;

namespace Infrastructure.Factories
{
    public class EntityFactory : IUserFactory
    {
        public User CreateUserInstance(string userIdentity, string userName, string email)
        {
            return new UserFactory(userIdentity, userName, email);
        }

    }
}
