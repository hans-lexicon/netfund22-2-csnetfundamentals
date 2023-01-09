using Microsoft.AspNetCore.Mvc;

namespace _03_AspNetMvc.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }
    }
}
