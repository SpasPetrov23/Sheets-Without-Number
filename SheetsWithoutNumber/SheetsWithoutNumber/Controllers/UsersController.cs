namespace SheetsWithoutNumber.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using SheetsWithoutNumber.Models.Users;
    using SWN.Data.Models;
    using System.Linq;
    using System.Threading.Tasks;

    public class UsersController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signinManager;

        public UsersController(UserManager<User> userManager, SignInManager<User> signinManager)
        {
            this.userManager = userManager;
            this.signinManager = signinManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterFormModel user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }

            var registeredUser = new User
            {
                Email = user.Email,
                UserName = user.Username
            };

            var registerUser = await this.userManager.FindByEmailAsync(user.Email);

            if (registerUser != null)
            {
                this.ModelState.AddModelError(string.Empty, "A user with that email address already exists.");

                return View(user);
            }

            var result = await userManager.CreateAsync(registeredUser, user.Password);

            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(e => e.Description);

                foreach (var error in errors)
                {
                    ModelState.AddModelError(string.Empty, error);
                }

                return View(user);
            }

            return RedirectToAction("Login", "Users");
        }

        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Login(LoginFormModel user)
        {
            const string error = "Credentials invalid!";

            if (!ModelState.IsValid)
            {
                return View(user);
            }

            var loggedInUser = await this.userManager.FindByEmailAsync(user.Email);

            if (loggedInUser == null)
            {
                this.ModelState.AddModelError(string.Empty, error);

                return View(user);
            }

            var passwordIsValid = await this.userManager.CheckPasswordAsync(loggedInUser, user.Password);

            if (!passwordIsValid)
            {
                this.ModelState.AddModelError(string.Empty, error);

                return View(user);
            }

            var shouldRemember = false;
            await this.signinManager.SignInAsync(loggedInUser, shouldRemember);

            var test = this.User.Identity.IsAuthenticated;
            var test2 = this.signinManager.SignInAsync(loggedInUser, shouldRemember);

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await this.signinManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
