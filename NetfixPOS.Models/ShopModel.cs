using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Models
{
    public class ShopModel
    {
        public int ShopId { get; set; }
        public byte[] ShopLogo { get; set; }
        public string ShopName { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string CurrentAddress { get; set; }
        public bool IsActive { get; set; }
    }
}
