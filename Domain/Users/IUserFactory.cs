using Domain.Users.ValueObjects;
using System.Threading.Tasks;

namespace Domain.Users
{
    public interface IUserFactory
    {
        User CreateUserInstance(string userIdentity, string userName, string email);
    }
}
