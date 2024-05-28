using CMS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CMS.Infrastructure.Data.UnitOfWorkl;

public partial class CMSDbContext
{
    public DbSet<User> User { get; set; }
    public DbSet<Blog> Blog { get; set; }
}
