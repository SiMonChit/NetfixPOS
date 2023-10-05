using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Models
{
    public class SupplierModel
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CurrentAddress { get; set; }
        public bool IsActive { get; set; }
    }
}
