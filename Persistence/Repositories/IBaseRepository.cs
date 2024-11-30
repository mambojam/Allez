namespace Persistence
{
    public interface IBaseRepository<T>
    {
        Task<T> Get(Guid id);
        Task<List<T>> GetAll();
        Task Create(T model);
        Task Edit(T model);
        Task Delete(Guid id);
    }
}