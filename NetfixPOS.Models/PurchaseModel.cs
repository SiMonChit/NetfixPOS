using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Models
{
    public class PurchaseModel
    {
		public int PurchaseId { get; set; }
		public int StockId { get; set; }
		public string StockName { get; set; }
		public decimal PurchasePrice { get; set; }
		public int Qty { get; set; }
		public decimal Amount { get; set; }
		public DateTime Pur_Date { get; set; }
		public int UserID { get; set; }
		public bool IsActive { get; set; }
	}
}
