using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Onion.UI.MVC_Core.Areas.AdminPanel.Controllers
{
    //[Authorize(Roles = "Admin")]
    [Area("AdminPanel")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
