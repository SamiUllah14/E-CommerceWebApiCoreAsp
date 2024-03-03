using E_CommerceApi.Models;
using System;
using System.Threading.Tasks;

namespace E_CommerceApi.Repository
{
    public interface IProductRepository : IRepository<ProductClass>
    {
        Task<ProductClass> UpdateAsync(ProductClass entity);

        Task<int> SaveChangesAsync();
    }
}
