using Microsoft.EntityFrameworkCore;
using WebApp.Contexts;
using WebApp.Models;

namespace WebApp.Services
{
    public class ProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetProductsByTag(string tag)
        {
            var products = new List<Product>();
            var _tag = await _context.Tags.Include(x => x.Products).ThenInclude(x => x.Category).FirstOrDefaultAsync(x => x.Tag == tag);
            if (_tag != null) 
            { 
                foreach(var product in _tag.Products) 
                {
                    products.Add(new Product
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Description = product.Description,
                        Price = product.Price,
                        ImageUrl = product.ImageUrl,
                        Tag = _tag.Tag,
                        Category = product.Category.Category
                    });
                }
            }

            return products;
        }
    }
}
