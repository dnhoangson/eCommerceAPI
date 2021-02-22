using Domain.Users.ValueObjects;

namespace Domain.Users.Commands
{
    public class CreateNewUserCommand : UserCommand
    {
        public CreateNewUserCommand(string userIdentity, string userName, string email)
        {
            UserIdentity = userIdentity;
            UserName = userName;
            Email = email;
        }
    }
}
