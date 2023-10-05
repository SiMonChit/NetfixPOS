using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Models
{
    public class UnitModel
    {
        public int UnitID { get; set; }
        public string UnitName { get; set; }
        public int DefaultQty { get; set; }
        public bool Active { get; set; }
    }
}
