using CMS.Core.Domain.Common;
using CMS.Core.Domain.Entities;
using CMS.Core.Domain.ValueObjects;
using CMS.Infrastructure.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Infrastructure.Data.Context;

public class CMSDbContext(DbContextOptions<CMSDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Blog>(entity =>
        //{
        //    entity.ToTable("Blog");
        //    entity.Property(e => e.Title).IsRequired();
        //    entity.Property(e => e.Title).HasMaxLength(100);
        //    entity.Property(e => e.Id).UseIdentityColumn();
        //});
        //modelBuilder.Entity<User>(entity =>
        //{
        //    entity.ToTable("User");
        //    entity.ComplexProperty(x => x.Addres);
        //});
        modelBuilder.RegisterAllEntities<BaseEntity>();
        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

}
