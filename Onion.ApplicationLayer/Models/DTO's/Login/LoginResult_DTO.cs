using Onion.CoreLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.ApplicationLayer.Models.DTO_s.Login
{
    public class LoginResult_DTO
    {
        public Uye Uye { get; set; }
        public bool IsAdmin { get; set; }
    }
}
