

namespace CMS.Infrastructure.Data.Repositories.Commands;

public class UserCommandRepository(CMSDbContext context) : GenericRepository<User>(context), IUserCommandRepository
{

}