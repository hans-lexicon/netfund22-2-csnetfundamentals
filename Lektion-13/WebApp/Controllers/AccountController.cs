using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models.Forms;
using WebApp.Services;

namespace WebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly AccountService _accountService;

        public AccountController(AccountService accountService)
        {
            _accountService = accountService;
        }






        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }









        [HttpGet]
        public IActionResult Register() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterFormModel form)
        {
            if(!ModelState.IsValid)
                return View(form);

            if (await _accountService.CheckIfUserExists(form.Email))
            {
                ViewData["UserAlreadyExists"] = "A user with the same e-mail address already exists.";
                return View(form);
            }

            if (await _accountService.RegisterAsync(form))
                return RedirectToAction("Login");

            return View(form);
        }









        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginFormModel form)
        {
            if (!ModelState.IsValid)
                return View(form);

            if (await _accountService.LoginAsync(form))
                return RedirectToAction("Index");

            return View(form);
        }







        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _accountService.LogoutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
