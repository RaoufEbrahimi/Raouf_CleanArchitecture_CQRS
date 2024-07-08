
using CMS.Core.Domain.Entities;
using CMS.Core.Domain.Interfaces.DTOs.Blog;


namespace CMS.Core.Domain.Interfaces.DAL.Queries
{
    public interface IBlogQueryRepository
    {

        Task<Blog> Find(int id);
        Task<IEnumerable<IUsersBlogsDto>> GetListUserBlogs(int id);

    }
}
