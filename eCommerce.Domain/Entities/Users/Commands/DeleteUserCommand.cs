using System;

namespace eCommerce.Domain.Entities.Users.Commands
{
    public class DeleteUserCommand : UserCommand
    {
        public DeleteUserCommand(Guid id)
        {
            Id = id;
        }
    }
}
