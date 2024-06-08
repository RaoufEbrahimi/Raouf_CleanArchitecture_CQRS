using CMS.Core.Domain.Entities;
using CMS.Core.Domain.Repositories.Queries;
using CMS.Infrastructure.Data.Context;

namespace CMS.Infrastructure.Data.Repositories
{
    public class BlogQueryRepository(CMSDbContext context) : GenericRepository<Blog>(context), IBlogQueryRepository
    {
       
    }
}