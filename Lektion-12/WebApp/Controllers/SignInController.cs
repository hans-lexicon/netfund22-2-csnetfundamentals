using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Models.Authentication;

namespace WebApp.Controllers
{
    public class SignInController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public SignInController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(SignInModel form)
        {
            if(!ModelState.IsValid)
                return View(form);

            var result = await _signInManager.PasswordSignInAsync(form.Email, form.Password, isPersistent: false, false);
            if (result.Succeeded)
                return RedirectToAction("Index", "Home");

            return View(form);
        }
    }
}
