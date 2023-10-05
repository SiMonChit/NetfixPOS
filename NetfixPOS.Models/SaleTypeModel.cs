using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Models
{
    public class SaleTypeModel
    {
        public int SaleTypeId { get; set; }
        public string SaleTypeName { get; set; }
        public bool IsActive { get; set; }

    }
}
