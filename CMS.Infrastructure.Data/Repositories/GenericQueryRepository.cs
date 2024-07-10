using System.Threading;

namespace CMS.Infrastructure.Data.Repositories;

public class GenericQueryRepository<TEntity> where TEntity : class, IEntity
{
    protected readonly CMSDbContext _context;
    public GenericQueryRepository(CMSDbContext context) => _context = context;
  
  
    public async Task<TEntity> Find(int id, CancellationToken cancellationToken) => await _context.Set<TEntity>().FindAsync(id, cancellationToken);

    public async Task<TResult> FirstOrDefaultAsyncAsNoTracking<TResult>(Expression<Func<TEntity, bool>> expression, Expression<Func<TEntity, TResult>> selector, CancellationToken cancellationToken)
    {
        return await _context.Set<TEntity>().AsNoTracking().Where(expression).Select(selector).FirstOrDefaultAsync(cancellationToken);
    }
    public async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken)
    {
        return await _context.Set<TEntity>().FirstOrDefaultAsync(expression, cancellationToken);
    }
    public async Task<IEnumerable<TResult>> GetListAsNoTrackingAsync<TResult>(Expression<Func<TEntity, bool>> expression, Expression<Func<TEntity, TResult>> selector, CancellationToken cancellationToken)
    {
        return await _context.Set<TEntity>().AsNoTracking().Where(expression).Select(selector).ToListAsync(cancellationToken);
    }
    public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken)
    {
        return await _context.Set<TEntity>().AnyAsync(expression, cancellationToken);
    }
}
