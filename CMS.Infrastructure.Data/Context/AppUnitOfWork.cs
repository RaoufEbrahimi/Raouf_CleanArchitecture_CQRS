using CMS.Core.Domain.Entities;
using CMS.Core.Domain.Interfaces.Repositories;
using CMS.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Infrastructure.Data.UnitOfWork
{
    public class AppUnitOfWork(CMSDbContext context) : IUnitOfWork
    {
        protected readonly CMSDbContext _context = context;

        public DbSet<User> Users => _context.Set<User>();
        public DbSet<Blog> Blog => _context.Set<Blog>();

        public Task<int> SaveChangeAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
