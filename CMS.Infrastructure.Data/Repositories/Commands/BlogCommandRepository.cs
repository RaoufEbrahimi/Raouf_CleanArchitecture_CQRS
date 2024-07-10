namespace CMS.Infrastructure.Data.Repositories.Commands;

public class BlogCommandRepository(CMSDbContext context) : GenericCommandRepository<Blog>(context), IBlogCommandRepository
{
 
}