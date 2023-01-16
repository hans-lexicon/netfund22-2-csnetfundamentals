using Microsoft.AspNetCore.Mvc;
using WebApp.Services;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductService _productService;

        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {

            var viewModel = new ProductsIndexViewModel
            {
                PageTitle = "Products",
                Breadcrumb = Request.Path,
                Products = await _productService.GetAllAsync()
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Details(int id)
        {
            var viewModel = new ProductsDetailsViewModel()
            {
                PageTitle = "Product Details",
                Breadcrumb = Request.Path,
                Product = await _productService.GetAsync(id)
            };

            ViewData["Title"] = "Product Details";
            return View(viewModel);
        }
    }
}
