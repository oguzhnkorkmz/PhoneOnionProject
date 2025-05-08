using Microsoft.AspNetCore.Identity;
using Onion.ApplicationLayer.Models.DTO_s.Login;
using Onion.CoreLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Onion.ApplicationLayer.Services.LoginService
{
    public class LoginSerive : ILoginService
    {
        private readonly UserManager<Uye> _userManager;

        public LoginSerive(UserManager<Uye> userManager)
        {
            _userManager = userManager;
        }

        public async Task<int> GetUserIDAsync(ClaimsPrincipal claim)
        {
            var user = await _userManager.GetUserAsync(claim);
            return user.Id;
        }



        //DAHA SONRA AUTO MAPHER EKLENECEK


        public async Task<LoginResult_DTO> LoginAsync(Login_DTO login)
        {
            LoginResult_DTO loginResult = new LoginResult_DTO() {Uye =null,IsAdmin=false};
            var uye = await _userManager.FindByNameAsync(login.KullaniciAdi);

            if(uye != null)
            {
                bool isPasswordCoorect = await _userManager.CheckPasswordAsync(uye, login.Sifre);

                if (isPasswordCoorect)
                {
                    loginResult.IsAdmin = await _userManager.IsInRoleAsync(uye, "Admin");
                    loginResult.Uye = uye;
                }
            }

            return loginResult;
        }

        public async Task<bool> RegisterUserAsync(RegisterUser_DTO user)
        {
            Uye yeniUye = new Uye()
            {
                Ad = user.Ad,
                SoyAd = user.SoyAd,
                Adres = user.Adres,
                Email = user.Email,
                UserName = user.UserName

            };
            var result = await _userManager.CreateAsync(yeniUye, user.Sifre);
            if (result.Succeeded)
                _userManager.AddToRoleAsync(yeniUye, "Uye");
            return result.Succeeded;
        }
    }
}
