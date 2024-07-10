using CMS.Core.Domain.Entities;
using CMS.Core.Domain.Interfaces.DAL.Queries;
using CMS.Infrastructure.Data.Context;

namespace CMS.Infrastructure.Data.Repositories.Commands
{
    public class UserQueryRepository(CMSDbContext context) : GenericQueryRepository<User>(context), IUserQueryRepository
    {
     
    }
}