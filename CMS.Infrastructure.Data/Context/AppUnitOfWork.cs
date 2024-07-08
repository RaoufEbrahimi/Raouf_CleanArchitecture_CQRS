using CMS.Core.Domain.Entities;
using CMS.Core.Domain.Interfaces.DAL;
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

        public async Task<int> SaveChangeAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
