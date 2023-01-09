using Microsoft.AspNetCore.Mvc;

namespace _03_AspNetMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
