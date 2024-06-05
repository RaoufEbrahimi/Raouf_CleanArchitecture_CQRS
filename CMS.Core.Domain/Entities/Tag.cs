using CMS.Core.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace CMS.Core.Domain.Entities;

public class Tag :BaseEntity
{
    
    public string Name { get; set; }
    public ICollection<Blog>? Blogs { get; set; }
}
