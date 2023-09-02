using Journal.Entities.Models;
using Journal.Persistence.Contracts;
using Journal.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Journal.Persistence.Repositories;

public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
{
    public CategoryRepository(AppDbContext appDbContext, ILogger logger)
        : base(appDbContext, logger) { }

    public override async Task<IEnumerable<Category>> All()
    {
        return await _dbSet.AsNoTracking().AsSplitQuery().ToListAsync();
    }
}
