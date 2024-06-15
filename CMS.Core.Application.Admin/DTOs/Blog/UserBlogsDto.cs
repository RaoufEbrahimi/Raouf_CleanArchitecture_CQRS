using CMS.Core.Domain.Interfaces.DTOs.Blog;

namespace CMS.Core.Application.Admin.DTOs.Blog;

public class UsersBlogsDto : IUsersBlogsDto
{
    public int BlogId { get; set; }
    public int UserId { get; set; }
    public string BlogTitle { get; set; }
    public string UserFullName { get; set; }    
}