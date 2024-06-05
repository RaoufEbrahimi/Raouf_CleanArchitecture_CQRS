using CMS.Core.Domain.Common;
using CMS.Core.Domain.Enums;
using CMS.Core.Domain.ValueObjects;

namespace CMS.Core.Domain.Entities;

public class User : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Gender Gender { get; set; }
    public Addres Addres { get; set; }
    public virtual ICollection<Blog> Blogs { get; set; }
}
