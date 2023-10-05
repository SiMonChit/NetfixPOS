using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Models
{
    public class CurrencyModel
    {
        public int CurrencyId { get; set; }
        public string Currency { get; set; }
        public string Symbol { get; set; }
        public bool IsDefault { get; set; }

    }
}
