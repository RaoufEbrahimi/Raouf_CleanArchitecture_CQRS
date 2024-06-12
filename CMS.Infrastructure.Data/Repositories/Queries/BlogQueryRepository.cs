using CMS.Core.Domain.DTOs.Blog;
using CMS.Core.Domain.Entities;
using CMS.Core.Domain.Interfaces.DTOs.Blog;
using CMS.Core.Domain.Interfaces.Repositories.Queries;
using CMS.Infrastructure.Data.Context;

namespace CMS.Infrastructure.Data.Repositories
{
    public class BlogQueryRepository(CMSDbContext context) : GenericRepository<Blog>(context), IBlogQueryRepository
    {
        public async Task<List<IUsersBlogsDto>> GetListUserBlogs(int id)
        {
            return await _context.Set<Blog>().Where(d=>d.UserId == id).Select(t=> new IUsersBlogsDto
            {
                BlogId = t.Id,
                UserId = t.UserId,
                BlogTitle = t.Title,
                UserName = t.User.FirstName + " " + t.User.LastName
            }).;
        }
    }
}