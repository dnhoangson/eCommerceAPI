using eCommerce.Domain.Users;

namespace eCommerce.ApplicationCore.Handlers
{
    public class UserCommandHandler
    {
        private readonly IUserFactory _userfactory;
        private readonly IUserRepository _userRepository;

        public UserCommandHandler(IUserFactory userFactory,
                                    IUserRepository userRepository)
        {
            _userfactory = userFactory;
            _userRepository = userRepository;
        }


    }
}
