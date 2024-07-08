using CMS.Core.Application.Admin.Features.BlogManagement.Queries.SearchBlogs.DTOs;
using CMS.Core.Domain.Interfaces.DTOs.Blog;

namespace CMS.Infrastructure.Data.Repositories;

public class BlogQueryRepository(CMSDbContext context) : GenericRepository<Blog>(context), IBlogQueryRepository
{
    public Task<Blog> Find(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<IUsersBlogsDto>> GetListUserBlogs(int id)
    {            
        return await _context.Set<Blog>().Where(d=>d.UserId == id).Select(t=> new UsersBlogsDto
        {
            BlogId = t.Id,
            UserId = t.UserId,
            BlogTitle = t.Title,
            UserFullName = t.User.FirstName + " " + t.User.LastName

        }).ToListAsync();
    }
}