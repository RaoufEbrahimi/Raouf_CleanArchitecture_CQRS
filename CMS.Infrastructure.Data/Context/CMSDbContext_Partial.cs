using CMS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Infrastructure.Data.UnitOfWorkl;

public partial class CMSDbContext
{
    public virtual DbSet<User> User { get; set; }
    public virtual DbSet<Blog> Blog { get; set; }
}
