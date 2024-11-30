namespace Application.Services
{
    public interface IBaseService<T>
    {
        Task<T> GetAsync(Guid id);
        Task<List<T>> GetAllAsync();
        Task CreateAsync(T model);
        Task EditAsync(Guid id, T model);
        Task DeleteAsync(Guid id);
    }
}