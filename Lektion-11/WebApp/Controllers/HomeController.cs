using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models.ViewModels;
using WebApp.Services;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductService _productService;

        public HomeController(ProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new HomeIndexViewModel
            {
                FeaturedProducts = await _productService.GetProductsByTag("Featured"),
                OutgoingProducts = await _productService.GetProductsByTag("Outgoing")
            };

            return View(viewModel);
        }
    }
}