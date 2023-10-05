using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Models
{
    public class AutoGenerateModel
    {
        public int GenerateID{get; set;}
        public DateTime GenerateDate{get; set;}
        public string GenerateNo{get; set;}
        public int LastValue{get; set;}
        public string GenerateType {get; set;}
    }
}
