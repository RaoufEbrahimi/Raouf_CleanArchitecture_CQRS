using CMS.Core.Domain.DTOs.Blog;
using CMS.Core.Domain.Entities;
using CMS.Core.Domain.Interfaces.DTOs.Blog;


namespace CMS.Core.Domain.Interfaces.Repositories.Queries
{
    public interface IBlogQueryRepository
    {

        Task<Blog> Find(int id);
        Task<List<IUsersBlogsDto>> GetListUserBlogs(int id);

    }
}
