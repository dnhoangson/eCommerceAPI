using eCommerce.Domain.Interfaces;

namespace eCommerce.Domain.Users
{
    public class User : BaseEntity, IAggregateRoot
    {
        public string UserIdentity { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Avatar { get; set; }
    }
}
