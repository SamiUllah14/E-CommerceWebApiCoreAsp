using E_CommerceApi.Models;
using System.Linq.Expressions;

namespace E_CommerceApi.Repository
{
    public interface  IRepository <T> where T : class
    {
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null);
        Task<List<T>> GetAsync(Expression<Func<T, bool>>? filter = null, bool tracked = true);
        Task CreateAsync(T entity);

        Task RemoveAsync(T entity);
        Task SaveAsync();
    }
}
