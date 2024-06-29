using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Application.Admin.Features.UserManagement.Commands.AddUser
{
    public class AddUserCommandHandler<> : IRequestHandler<AddUserCommand>
    {
        public Task Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
