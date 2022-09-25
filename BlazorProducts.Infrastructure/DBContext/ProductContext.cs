using BlazorProducts.Core.Models;
using BlazorProducts.Infrastructure.DBContext.Configuration;
using Microsoft.EntityFrameworkCore;

namespace BlazorProducts.Infrastructure.DBContext
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }

        public DbSet<Product> Products { get; set; }
    }
}
