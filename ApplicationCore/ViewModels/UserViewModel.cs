using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel()
        {

        }

        public UserViewModel(Guid id, string userIdentity, string userName, string email)
        {
            Id = id.ToString();
            UserIdentity = userIdentity;
            UserName = userName;
            Email = email;
        }

        public string Id { get; set; }
        public string UserIdentity { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
