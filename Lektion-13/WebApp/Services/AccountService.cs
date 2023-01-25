using Microsoft.AspNetCore.Identity;
using WebApp.Models.Forms;
using WebApp.Models.Identity;

namespace WebApp.Services
{
    public class AccountService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<bool> RegisterAsync(RegisterFormModel form) 
        {
            var user = new ApplicationUser
            {
                UserName = form.Email,
                Email = form.Email,
                FirstName = form.FirstName,
                LastName = form.LastName
            };

            var result = await _userManager.CreateAsync(user, form.Password);
            if (result.Succeeded)
                return true;

            return false;
        }

        public async Task<bool> LoginAsync(LoginFormModel form)
        {
            var result = await _signInManager.PasswordSignInAsync(form.Email, form.Password, isPersistent: false, false);
            if (result.Succeeded)
                return true;

            return false;
        }

        public async Task LogoutAsync() 
        {
           await _signInManager.SignOutAsync();
        }


        public async Task<bool> CheckIfUserExists(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user != null)
                return true;

            return false;
        }

    }
}
