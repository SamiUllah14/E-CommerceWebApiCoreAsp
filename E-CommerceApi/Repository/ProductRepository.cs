using E_CommerceApi.Data;
using E_CommerceApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace E_CommerceApi.Repository
{
    public class ProductRepository : Repository<ProductClass>, IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<ProductClass> UpdateAsync(ProductClass entity)
        {
            entity.UpdateDate = DateTime.Now;
            _context.EcomProducts_API.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
