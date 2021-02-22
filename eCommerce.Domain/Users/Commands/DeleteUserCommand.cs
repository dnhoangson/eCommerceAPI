using System;

namespace eCommerce.Domain.Users.Commands
{
    public class DeleteUserCommand : UserCommand
    {
        public DeleteUserCommand(Guid id)
        {
            Id = id;
        }
    }
}
