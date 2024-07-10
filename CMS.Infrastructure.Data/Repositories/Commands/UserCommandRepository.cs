

namespace CMS.Infrastructure.Data.Repositories.Commands;

public class UserCommandRepository(CMSDbContext context) : GenericCommandRepository<User>(context), IUserCommandRepository
{

}