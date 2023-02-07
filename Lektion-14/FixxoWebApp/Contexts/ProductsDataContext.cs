using FixxoWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FixxoWebApp.Contexts
{
    public class ProductsDataContext : DbContext
    {
        public ProductsDataContext(DbContextOptions<ProductsDataContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
