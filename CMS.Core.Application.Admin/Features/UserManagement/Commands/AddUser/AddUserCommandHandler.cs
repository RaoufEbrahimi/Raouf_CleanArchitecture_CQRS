namespace CMS.Core.Application.Admin.Features.UserManagement.Commands.AddUser;

public class AddUserCommandHandler(IUserCommandRepository userCommandRepository) : IRequestHandler<AddUserCommand, bool>
{
    private readonly IUserCommandRepository _userCommandRepository = userCommandRepository;

    public async Task<bool> Handle(AddUserCommand request, CancellationToken cancellationToken)
    {
        try
        {
            await _userCommandRepository.Add(new User
            {
                Addres = request.Addres,
                AliasName = request.AliasName,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Gender = request.Gender,
            });
            return true;
        }
        catch (Exception ex)
        {

            throw;
        }
        throw new NotImplementedException();
    }
}
