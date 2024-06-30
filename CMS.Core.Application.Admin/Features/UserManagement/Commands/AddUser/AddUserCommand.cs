using CMS.Core.Domain.Enums;
using CMS.Core.Domain.ValueObjects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Application.Admin.Features.UserManagement.Commands.AddUser
{
    public record AddUserCommand : IRequest<bool>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AliasName { get; set; }
        public Gender Gender { get; set; }
        public Addres Addres { get; set; }

    }
}
