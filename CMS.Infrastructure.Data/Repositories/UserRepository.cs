using CMS.Core.Domain.Entities;
using CMS.Core.Domain.Repositories;
using CMS.Infrastructure.Data.Context;

namespace CMS.Infrastructure.Data.Repositories
{
    public class UserRepository(CMSDbContext context) : GenericRepository<User>(context), IUserRepository
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