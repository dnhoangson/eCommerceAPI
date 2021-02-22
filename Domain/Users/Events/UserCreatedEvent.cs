using Domain.Users.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users.Events
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
