using CMS.Infrastructure.Data.Extensions;
using System.Reflection;

namespace CMS.Infrastructure.Data.Context;

public class CMSDbContext(DbContextOptions<CMSDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("CMS");
        modelBuilder.RegisterAllEntities<BaseEntity>();
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

}
