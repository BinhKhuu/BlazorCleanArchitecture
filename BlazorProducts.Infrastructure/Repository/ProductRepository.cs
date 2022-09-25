using BlazorProducts.Core.Models;
using BlazorProducts.Core.Repositories;
using BlazorProducts.Infrastructure.DBContext;
using Microsoft.EntityFrameworkCore;

namespace BlazorProducts.Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _context;

        public ProductRepository(ProductContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetProducts() => await _context.Products.ToListAsync();
    }
}
