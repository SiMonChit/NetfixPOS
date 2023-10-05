using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Models
{
    public class DamageModel
    {
		public int DamageId { get; set; }
		public string TableOrRoom { get; set; }
		public string Dmg_Description { get; set; }

		public decimal Dmg_Charges { get; set; }
		public string Dmg_Approver { get; set; }
		public int UserID { get; set; }
		public DateTime Dmg_Date { get; set; }
		public int CashReceiptId { get; set; }
		public bool IsActive { get; set; }
	}
}
