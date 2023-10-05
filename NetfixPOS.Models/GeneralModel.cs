using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Models
{
    public class GeneralModel
    {
        public int General_Id { get; set; }
        public int ShopId { get; set; }
        public DateTime SaleDate { get; set; }
        public string ActivateKey { get; set; }
        public decimal ServiceTax { get; set; }
        public bool IsActive { get; set; }
        public decimal InvDiscount { get; set; }
    }
}
