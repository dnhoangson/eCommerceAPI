using System;

namespace Domain.Users.Commands
{
    public class DeleteUserCommand : UserCommand
    {
        public DeleteUserCommand(Guid id)
        {
            Id = id;
        }
    }
}
