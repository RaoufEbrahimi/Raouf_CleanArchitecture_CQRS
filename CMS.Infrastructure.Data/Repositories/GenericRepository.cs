using System.Threading;

namespace CMS.Infrastructure.Data.Repositories;

public class GenericRepository<TEntity> where TEntity : class, IEntity
{
    protected readonly CMSDbContext _context;
    public GenericRepository(CMSDbContext context) => _context = context;
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
