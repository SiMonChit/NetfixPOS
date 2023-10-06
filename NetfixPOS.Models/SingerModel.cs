using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Models
{
    public class SingerModel
    {
        public int SingerId { get; set; }
        public string SingerCode { get; set; }
        public string SingerName { get; set; }
        public string ContactPhone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }

    }
}
