using CMS.Core.Domain.Interfaces.Repositories.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Application.Admin.Features.UserManagement.Commands.AddUser
{
    public class AddUserCommandHandler(IUserCommandRepository userCommandRepository) : IRequestHandler<AddUserCommand, bool>
    {
        private readonly IUserCommandRepository _userCommandRepository= userCommandRepository;
 
        public Task<bool> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
