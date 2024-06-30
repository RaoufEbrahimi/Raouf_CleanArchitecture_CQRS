using CMS.Core.Domain.Interfaces.Repositories.Queries;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Application.Admin.Features.UserManagement.Commands.AddUser;

public class AddUserValidator : AbstractValidator<AddUserCommand>
{
    private readonly IUserQueryRepository _userQueryRepository;
    public AddUserValidator(IUserQueryRepository userQueryRepository)
    {
        _userQueryRepository = userQueryRepository;

        RuleFor(x => x.FirstName)
            .NotNull().NotEmpty().WithMessage("First Name cannot be null");
        
        RuleFor(x => x.LastName)
            .NotNull().NotEmpty().WithMessage("Last Name cannot be null");

        RuleFor(x => x.AliasName)
            .MustAsync(IsThisNameExist).WithMessage("Last Name cannot be null");
    }

    private async Task<bool> IsThisNameExist(string aliasName, CancellationToken cancellationToken) => await _userQueryRepository.AnyAsync(d => d.AliasName == aliasName, cancellationToken);

}
