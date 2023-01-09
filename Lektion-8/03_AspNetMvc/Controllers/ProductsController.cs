using Microsoft.AspNetCore.Mvc;

namespace _03_AspNetMvc.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
