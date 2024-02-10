namespace Play.Common.Interfaces
{
    /// <summary>
    /// Repository Generic
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : IEntity
    {
        Task<IReadOnlyCollection<T>> GetAllAsync();
        Task<T> GetAsync(Guid id);
        Task CreateAsync(T item);
        Task UpdateAsync(T item);
        Task RemoveAsync(Guid id);
    }
}