using CMS.Core.Domain.Repositories;
using CMS.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Infrastructure.Data.UnitOfWork
{
    public class AppUnitOfWork : IUnitOfWork
    {

        public AppUnitOfWork(CMSDbContext context)
        {
            
        }
        public Task<int> SaveChangeAsync()
        {
            throw new NotImplementedException();
        }
    }
}
