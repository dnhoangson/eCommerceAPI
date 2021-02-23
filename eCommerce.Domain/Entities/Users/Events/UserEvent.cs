using eCommerce.Domain.Entities.Users.ValueObjects;
using System;

namespace eCommerce.Domain.Entities.Users.Events
{
    public class UserEvent
    {
        public Guid Id { get; set; }
        public string UserIdentity { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public UserAddress Address { get; set; }
        public string Avatar { get; set; }
    }
}
