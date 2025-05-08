using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Onion.ApplicationLayer.Models.DTO_s.Telefon;
using Onion.ApplicationLayer.Services.IsletimSistemiService;
using Onion.ApplicationLayer.Services.MarkaService;
using Onion.ApplicationLayer.Services.ModelService;
using Onion.ApplicationLayer.Services.TelefonService;
using Onion.UI.MVC_Core.Models.ViewModels;
using Onion.UI.MVC_Core.Utilites;

namespace Onion.UI.MVC_Core.Areas.AdminPanel.Controllers
{
    
    [Area("AdminPanel")]
    public class TelefonController : Controller
    {
        private readonly ITelefonService _telefonService;
        private readonly IMarkaService _markaService;
        private readonly IModelService _modelService;
        private readonly IIsletimSistemiService _isletimSistemiService;
        private readonly IMapper _mapper;

        public TelefonController(ITelefonService telefonService, IMarkaService markaService, IModelService modelService, IIsletimSistemiService isletimSistemi, IMapper mapper)
        {
            _telefonService = telefonService;
            _markaService = markaService;
            _modelService = modelService;
            _isletimSistemiService = isletimSistemi;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _telefonService.TumTelefonlarAsync());
        }

        public async Task<IActionResult> Ekle(int? id)
        {
         
            TelefonEklemeFormu_VM telefonForm = new TelefonEklemeFormu_VM();

            var markalar = await _markaService.TumMarkalarAsync();

            if(id == null)
                id = markalar.FirstOrDefault().MarkaID;

            telefonForm.Markalar = new SelectList(markalar, "MarkaID", "MarkaAdi",id);

            telefonForm.Modeller = new SelectList(await _modelService.TumModellerAsync(id), "ModelID", "ModelAdi");
            telefonForm.IsletimSistemleri = new SelectList(await _isletimSistemiService.TumIsletimSistemleriAsync(), "IsletimSistemiID", "IsletimSistemiAdi");
            return View(telefonForm);
        }

        [HttpPost]
        public async Task<IActionResult> Ekle(EkleTelefon_VM telefon)
        {
            TelefonEkle_DTO yeniTelefon = new TelefonEkle_DTO();
            string strFileNameWithGuid = await FileOperations.UploadImageAsync(telefon.Resim);

            _mapper.Map(telefon, yeniTelefon);

            yeniTelefon.Resim = strFileNameWithGuid;
            await _telefonService.TelefonEkleAsync(yeniTelefon);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Sil(int id)
        {
            await _telefonService.TelefonSilAsync(id);
            return RedirectToAction("Index");
        }
    }
}
