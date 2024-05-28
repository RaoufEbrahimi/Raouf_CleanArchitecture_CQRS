using CMS.Core.Domain.Entities;
using CMS.Core.Domain.Repositories;
using CMS.Infrastructure.Data.Context;

namespace CMS.Infrastructure.Data.Repositories
{
    public class BlogRepository(CMSDbContext context) : GenericRepository<Blog>(context), IBlogRepository
    {
       
    }
}