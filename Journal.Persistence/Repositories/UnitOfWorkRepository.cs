using Journal.Persistence.Contracts;
using Journal.Persistence.Data;
using Microsoft.Extensions.Logging;

namespace Journal.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    public readonly AppDbContext _appDbContext;

    /* add all access to entity repositories here */
    public ICategoryRepository Categories { get; }

    public UnitOfWork(AppDbContext appDbContext, ILoggerFactory loggerFactory)
    {
        _appDbContext = appDbContext;
        var logger = loggerFactory.CreateLogger("logs");
        Categories = new CategoryRepository(_appDbContext, logger);
    }

    public async Task CompleteAsync()
    {
        await _appDbContext.SaveChangesAsync();
    }

    public void Dispose()
    {
        _appDbContext.DisposeAsync();
    }
}
