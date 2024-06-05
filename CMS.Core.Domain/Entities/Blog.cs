using CMS.Core.Domain.Common;

namespace CMS.Core.Domain.Entities;

public class Blog : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreateDateTime { get; set; }
    public User User { get; set; }
    public int UserId { get; set; }
    public ICollection<Tag>? Tags { get; set; }

}
