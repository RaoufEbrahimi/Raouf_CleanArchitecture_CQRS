using CMS.Core.Domain.Common;
using CMS.Core.Domain.Entities;
using CMS.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Infrastructure.Data.Repositories;

public class GenericRepository<TEntity> where TEntity : IEntity
{
    protected readonly CMSDbContext _context;
    public GenericRepository(CMSDbContext context) => _context = context;
    public async Task Add(TEntity entity)
    {

    }
    public async Task Update(TEntity entity)
    {

    }
    public async Task Delete(TEntity entity)
    {
       
    }
   //public async Task<TEntity> Find(int id)
   // {
   //     return TEntity;
   // }

}
