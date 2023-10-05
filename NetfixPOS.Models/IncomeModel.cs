using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Models
{
    public class IncomeModel
    {
        public int IncomeId { get; set; }
		public string In_Description { get; set; }
		public DateTime In_Date { get; set; }
		public decimal In_Amount { get; set; }
		public bool IsActive { get; set; }
		public int UserID { get; set; }
	}
}
