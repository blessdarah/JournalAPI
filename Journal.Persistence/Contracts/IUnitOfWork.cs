namespace Journal.Persistence.Contracts;

public interface IUnitOfWork
{
    ICategoryRepository Categories { get; }

    Task CompleteAsync();
}
