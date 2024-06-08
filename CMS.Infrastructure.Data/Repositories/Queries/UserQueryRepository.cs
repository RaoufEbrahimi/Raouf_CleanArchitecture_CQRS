using CMS.Core.Domain.Entities;
using CMS.Core.Domain.Repositories.Queries;
using CMS.Infrastructure.Data.Context;

namespace CMS.Infrastructure.Data.Repositories.Commands
{
    public class UserQueryRepository(CMSDbContext context) : GenericRepository<User>(context), IUserQueryRepository
    {
        public Task Add(User user)
        {
            throw new NotImplementedException();
        }

        public Task Find(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}