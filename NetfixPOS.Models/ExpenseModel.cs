using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Models
{
    public class ExpenseModel
    {
		public int ExpenseId { get; set; }
		public string Ex_Description { get; set; }
		public DateTime Ex_Date { get; set; }
		public decimal Ex_Amount { get; set; }
		public bool IsActive { get; set; }
		public int UserID { get; set; }
	}
}
