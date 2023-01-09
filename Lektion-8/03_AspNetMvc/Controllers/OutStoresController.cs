using Microsoft.AspNetCore.Mvc;

namespace _03_AspNetMvc.Controllers
{
    public class OutStoresController : Controller
    {
        public IActionResult Index()
        {
            ViewData["PageTitle"] = "stores & Services";
            return View();
        }

        public IActionResult Locations()
        {
            ViewData["PageTitle"] = "Locations & Hours";
            return View();
        }

        public IActionResult Events()
        {
            ViewData["PageTitle"] = "Store Events";
            return View();
        }

        public IActionResult Catalogs()
        {
            ViewData["PageTitle"] = "Catalogs";
            return View();
        }
    }
}
