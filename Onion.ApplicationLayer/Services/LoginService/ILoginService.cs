using Onion.ApplicationLayer.Models.DTO_s.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Onion.ApplicationLayer.Services.LoginService
{
    public interface ILoginService
    {
        //uyeID,admin
        public Task<LoginResult_DTO> LoginAsync(Login_DTO login);

        public Task<bool> RegisterUserAsync(RegisterUser_DTO user);

        public Task<int> GetUserIDAsync(ClaimsPrincipal claim);

    }
}
