using System.Threading;

namespace CMS.Infrastructure.Data.Repositories;

public class GenericCommandRepository<TEntity> where TEntity : class, IEntity
{
    protected readonly CMSDbContext _context;
    public GenericCommandRepository(CMSDbContext context) => _context = context;
    public async Task Add(TEntity entity)
    {
        _context.Set<TEntity>().Add(entity);
    }
    public async Task Update(TEntity entity)
    {
        _context.Set<TEntity>().Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;
    }
    public async Task Delete(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);
    }
  
}
