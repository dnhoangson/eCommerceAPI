using Domain.Users.ValueObjects;
using System;

namespace Domain.Users
{
    public class User : IAggregateRoot
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
