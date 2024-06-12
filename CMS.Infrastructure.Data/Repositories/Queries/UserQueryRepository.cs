using CMS.Core.Domain.Entities;
using CMS.Core.Domain.Interfaces.Repositories.Queries;
using CMS.Infrastructure.Data.Context;

namespace CMS.Infrastructure.Data.Repositories.Commands
{
    public class UserQueryRepository(CMSDbContext context) : GenericRepository<User>(context), IUserQueryRepository
    {

    }
}