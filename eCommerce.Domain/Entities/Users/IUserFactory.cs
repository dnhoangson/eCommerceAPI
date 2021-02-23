namespace eCommerce.Domain.Entities.Users
{
    public interface IUserFactory
    {
        User CreateUserInstance(string userIdentity, string userName, string email);
    }
}
