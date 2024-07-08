

namespace CMS.Infrastructure.Data.Repositories.Commands;

public class BlogCommandRepository(CMSDbContext context) : GenericRepository<Blog>(context), IBlogCommandRepository
{

}