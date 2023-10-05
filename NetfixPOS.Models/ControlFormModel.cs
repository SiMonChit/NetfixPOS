using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Models
{
    public class ControlFormModel
    {
        public int ControlId { get; set; }
        public string ControlForm { get; set; }
        public bool IsActive { get; set; }
    }
}
