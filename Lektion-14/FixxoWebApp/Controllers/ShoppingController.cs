using FixxoWebApp.Contexts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FixxoWebApp.Controllers
{
    [Authorize]
    public class ShoppingController : Controller
    {
        private readonly ProductsDataContext _productCatalog;
        private readonly DataContext _dataContext;

        public ShoppingController(ProductsDataContext productCatalog, DataContext dataContext)
        {
            _productCatalog = productCatalog;
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {



            ViewData["Title"] = "Shopping Cart";
            return View();
        }
    }
}
