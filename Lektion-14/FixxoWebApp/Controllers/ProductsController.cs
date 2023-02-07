using FixxoWebApp.Contexts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FixxoWebApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductsDataContext _context;
  

        public ProductsController(ProductsDataContext context)
        {
            _context = context;
        }


        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.Where(product => product.Price > 1000m).ToListAsync();

            ViewData["Title"] = "Products";
            return View(products);
        }

        public IActionResult Search()
        {
            ViewData["Title"] = "Search Products";
            return View();
        }

        public IActionResult Compare()
        {
            ViewData["Title"] = "Compare Products";
            return View();
        }
    }
}
