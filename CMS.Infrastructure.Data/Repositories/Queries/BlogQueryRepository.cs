using CMS.Core.Application.Admin.Features.BlogManagement.Queries.SearchBlogs.DTOs;
using CMS.Core.Domain.Interfaces.DTOs.Blog;

namespace CMS.Infrastructure.Data.Repositories;

public class BlogQueryRepository(CMSDbContext context) : GenericQueryRepository<Blog>(context), IBlogQueryRepository
{
   
    public async Task<IEnumerable<IUsersBlogsDto>> GetListUserBlogs(int id, CancellationToken cancellationToken)
    {            
        return await _context.Set<Blog>().Where(d=>d.UserId == id).Select(t=> new UsersBlogsDto
        {
            BlogId = t.Id,
            UserId = t.UserId,
            BlogTitle = t.Title,
            UserFullName = t.User.FirstName + " " + t.User.LastName

        }).ToListAsync(cancellationToken);
    }
}