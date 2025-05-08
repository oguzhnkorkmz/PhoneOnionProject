namespace Onion.UI.MVC_Core.Models.ViewModels
{
    public class EkleTelefon_VM
    {
        public int MarkaID { get; set; }
        public int? ModelID { get; set; }
        public int IsletimSistemiID { get; set; }
        public decimal Fiyat { get; set; }

        public IFormFile Resim { get; set; }
        public string Aciklama { get; set; }
        public bool CiftSim { get; set; }
        public short Stok { get; set; }

    }
}
