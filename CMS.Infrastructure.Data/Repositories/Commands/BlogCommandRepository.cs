using CMS.Core.Domain.Entities;
using CMS.Core.Domain.Repositories.Commands;
using CMS.Infrastructure.Data.Context;

namespace CMS.Infrastructure.Data.Repositories.Commands
{
    public class BlogCommandRepository(CMSDbContext context) : GenericRepository<Blog>(context), IBlogCommandRepository
    {

    }
}