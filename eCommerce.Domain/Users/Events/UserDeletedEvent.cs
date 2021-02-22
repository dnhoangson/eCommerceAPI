using System;

namespace eCommerce.Domain.Users.Events
{
    public class UserDeletedEvent : UserEvent
    {
        public UserDeletedEvent(Guid id)
        {
            Id = id;
        }
    }
}
