using Microsoft.AspNetCore.Mvc;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Contacts()
        {

            var viewModel = new AboutContactsViewModel
            {
                PageTitle = "Contact Us",
                Breadcrumb = Request.Path
            };

            return View(viewModel);
        }
    }
}
