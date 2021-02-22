using Domain.Users;
using FluentMediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Handlers
{
    public class UserCommandHandler
    {
        private readonly IUserFactory _userfactory;
        private readonly IUserRepository _userRepository;
        private readonly IMediator _mediator;

        public UserCommandHandler(IUserFactory userFactory, 
                                    IUserRepository userRepository,
                                    IMediator mediator)
        {
            _userfactory = userFactory;
            _userRepository = userRepository;
            _mediator = mediator;
        }
    }
}
