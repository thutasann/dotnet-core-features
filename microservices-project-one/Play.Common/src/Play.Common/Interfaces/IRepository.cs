using System.Linq.Expressions;

namespace Play.Common.Interfaces
{
    /// <summary>
    /// Repository Generic
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : IEntity
    {
        Task<IReadOnlyCollection<T>> GetAllAsync();
        /// <summary>
        /// GetAllAsync with Filter
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        Task<IReadOnlyCollection<T>> GetAllAsync(Expression<Func<T, bool>> filter);
        Task<T> GetAsync(Guid id);
        /// <summary>
        /// Get Async with Filter
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        Task<T> GetAsync(Expression<Func<T, bool>> filter);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(Guid id);
    }
}