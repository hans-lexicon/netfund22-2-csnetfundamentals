using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
	public class ProductsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Search()
		{
			return View();
		}

		public IActionResult Compare()
		{
			return View();
		}

		public IActionResult WishList()
		{
			return View();
		}
	}
}
