using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Onion.UI.MVC_Core.Models.ViewModels;
using Onion.ApplicationLayer.Models.DTO_s.Login;
using Onion.ApplicationLayer.Services.LoginService;
using Onion.CoreLayer.Models;
using System.Threading.Tasks;

namespace Onion.UI.MVC_Core.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginService _loginService;
        private readonly SignInManager<Uye> signInManager;

        public LoginController(ILoginService loginService, SignInManager<Uye> signInManager)
        {
            _loginService = loginService;
            this.signInManager = signInManager;
        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(Login_DTO login)
        {
            if (ModelState.IsValid)
            {
                var result = await _loginService.LoginAsync(login);

                if (result != null && result.Uye?.Id > 0) // Kullanıcı bulunduysa
                {
                    await signInManager.SignInAsync(result.Uye, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Kullanıcı adı veya şifre yanlış.");
                }
            }

            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterUser_VM uye)
        {
            if (ModelState.IsValid)
            {
                RegisterUser_DTO registerUser = new RegisterUser_DTO()
                {
                    Ad = uye.Ad,
                    SoyAd = uye.SoyAd,
                    Adres = uye.Adres,
                    Email = uye.Email,
                    UserName = uye.UserName,
                    Sifre = uye.Sifre

                };

                var result = await _loginService.RegisterUserAsync(registerUser);
                if (result)
                    return RedirectToAction("Login");

            }
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }

    }
}
