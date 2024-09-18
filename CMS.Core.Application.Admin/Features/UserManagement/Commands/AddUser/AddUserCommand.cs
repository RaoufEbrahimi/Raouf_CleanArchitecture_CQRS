using CMS.Core.Domain.Common.ErrorOr;
using CMS.Core.Domain.Enums;
using CMS.Core.Domain.ValueObjects;

namespace CMS.Core.Application.Admin.Features.UserManagement.Commands.AddUser;

public record AddUserCommand : IRequest<ErrorOr<bool>>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string AliasName { get; set; }
    public Gender Gender { get; set; }
    public Addres Addres { get; set; }

}
