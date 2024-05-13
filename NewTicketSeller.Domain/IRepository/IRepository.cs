namespace NewTicketSeller.Domain.IRepository;

public interface IRepository<T> where T : class
{
    Task<IEnumerable<T>?> GetAllAsync();
    Task<T?> GetAsync(int id);
    Task CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task SaveAsync();
}
