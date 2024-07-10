namespace CMS.Core.Domain.Interfaces.DAL;

public interface IUnitOfWork
{
    Task<int> SaveChangeAsync(CancellationToken cancellationToken);
}
