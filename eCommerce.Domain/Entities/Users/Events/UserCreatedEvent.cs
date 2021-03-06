﻿using System;

namespace eCommerce.Domain.Entities.Users.Events
{
    public class UserCreatedEvent : UserEvent
    {
        public UserCreatedEvent(Guid id, string userIdentity, string userName, string email)
        {
            Id = id;
            UserIdentity = userIdentity;
            UserName = userName;
            Email = email;
        }
    }
}
