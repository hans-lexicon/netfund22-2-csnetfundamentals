using Microsoft.AspNetCore.Mvc;

namespace FixxoWebApp.Controllers
{
    public class FavoritesController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Wish List";
            return View();
        }
    }
}
