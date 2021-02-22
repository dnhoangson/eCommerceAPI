using Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Factories
{
    public class UserFactory : User
    {
        public UserFactory()
        {

        }

        public UserFactory(string userIdentity, string userName, string email)
        {
            UserIdentity = userIdentity;
            UserName = userName;
            Email = email;
        }
    }
}
