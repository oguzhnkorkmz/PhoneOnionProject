using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Onion.ApplicationLayer.Models.DTO_s.Sepet;
using Onion.ApplicationLayer.Services.LoginService;
using Onion.ApplicationLayer.Services.SepetService;
using System.Threading.Tasks;

namespace Onion.UI.MVC_Core.Areas.UyePanel.Controllers
{

    //[Authorize]
    [Area("UyePanel")]
    public class HomeController : Controller
    {
        private readonly ILoginService _loginServise;
        private readonly ISepetService _sepetServise;
        private readonly IMapper _mapper;

        public HomeController(ILoginService loginServise, ISepetService sepetServise, IMapper mapper)
        {
            _loginServise = loginServise;
            _sepetServise = sepetServise;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            int uyeID = await _loginServise.GetUserIDAsync(User);
            var sepettekiUrunler = await _sepetServise.SepettekiTumUrunlerAsync(uyeID);
            return View(sepettekiUrunler);
        }

        public async Task<IActionResult> SepeteEkle(int id)
        {
            int uyeID = await _loginServise.GetUserIDAsync(User);

            SepeteEkle_DTO sepeteEkle = new SepeteEkle_DTO()
            {
                UyeID = uyeID,
                TelefonID = id,
                Adet = 1
            };
        
            await _sepetServise.SepeteEkleAsync(sepeteEkle);
            return NoContent();
        }

        public async Task<IActionResult> SepettenSil(int id)
        {
            await _sepetServise.SepettenKaliciSilAsync(id);
            return RedirectToAction("Index");
        }
    }
}
