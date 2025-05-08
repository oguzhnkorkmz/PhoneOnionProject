using System.ComponentModel.DataAnnotations;

namespace Onion.UI.MVC_Core.Models.ViewModels
{
    public class RegisterUser_VM
    {
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public string Adres { get; set; }

        public string UserName { get; set; }

        [EmailAddress(ErrorMessage ="EPosta adresi geçerli değil...")]
        public string Email { get; set; }

        [Compare("SifreTekrari",ErrorMessage ="Şifreler uyuşmuyor")]
        public string Sifre { get; set; }
        public string SifreTekrari { get; set; }
    }
}
