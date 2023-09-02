using System.Linq.Expressions;
using Journal.Persistence.Contracts;
using Journal.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Journal.Persistence.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    protected readonly AppDbContext _appDbContext;
    protected readonly ILogger _logger;
    internal DbSet<T> _dbSet;

    public BaseRepository(AppDbContext appDbContext, ILogger logger)
    {
        _appDbContext = appDbContext;
        _logger = logger;
        _dbSet = appDbContext.Set<T>();
    }

    public async Task<bool> Add(T entity)
    {
        await _dbSet.AddAsync(entity);
        return true;
    }

    public virtual Task<IEnumerable<T>> All()
    {
        throw new NotImplementedException();
    }

    public virtual Task<bool> Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public virtual Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Upsert(T entity)
    {
        throw new NotImplementedException();
    }
}
