using FixxoWebApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FixxoWebApp.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthenticationController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [Route("/restricted")]
        public IActionResult Restricted(string returnUrl = null!)
        {
            return View();
        }




        [Route("/register")]
        public IActionResult Register(string returnUrl = null!)
        {
            var form = new RegisterForm();
            if (returnUrl != null)
                form.ReturnUrl = returnUrl;

            return View(form);
        }

        [HttpPost]
        [Route("/register")]
        public async Task<IActionResult> Register(RegisterForm form)
        {
            if (ModelState.IsValid)
            {
                var role = "user";

                if(!_roleManager.Roles.Any() && !_userManager.Users.Any())
                {
                    await _roleManager.CreateAsync(new IdentityRole("admin"));
                    await _roleManager.CreateAsync(new IdentityRole("user"));

                    role = "admin";
                }
                
                
                var user = new ApplicationUser
                {
                    FirstName = form.FirstName,
                    LastName = form.LastName,
                    Email = form.Email,
                    StreetName = form.StreetName,
                    PostalCode= form.PostalCode,
                    City = form.City,
                    UserName = form.Email
                };
                
                var create_result = await _userManager.CreateAsync(user, form.Password);
                if (create_result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, role);

                    var signIn_result = await _signInManager.PasswordSignInAsync(user.Email, form.Password, true, false);
                    if (signIn_result.Succeeded)
                        return LocalRedirect(form.ReturnUrl);
                    else 
                        return RedirectToAction(nameof(Login));
                }

                ModelState.AddModelError(string.Empty, "Unable to create your account");
            }

            return View(form);
        }








        [Route("/login")]
        public IActionResult Login(string returnUrl = null!)
        {
            var form = new LoginForm();
            if (returnUrl != null)
                form.ReturnUrl = returnUrl;
            

            return View(form);
        }

        [HttpPost]
        [Route("/login")]
        public async Task<IActionResult> Login(LoginForm form)
        {

            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(form.Email, form.Password, true, false);
                if (result.Succeeded)
                    return LocalRedirect(form.ReturnUrl);

                ModelState.AddModelError(string.Empty, "Incorrect email or password");
            }

            return View(form);
        }


        [Route("/logout")]
        public async Task<IActionResult> Logout()
        {
            if (_signInManager.IsSignedIn(User))
                await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
