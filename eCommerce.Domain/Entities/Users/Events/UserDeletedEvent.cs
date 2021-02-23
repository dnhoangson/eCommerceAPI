using System;

namespace eCommerce.Domain.Entities.Users.Events
{
    public class UserDeletedEvent : UserEvent
    {
        public UserDeletedEvent(Guid id)
        {
            Id = id;
        }
    }
}
