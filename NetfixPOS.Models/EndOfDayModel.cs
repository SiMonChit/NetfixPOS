using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Models
{
    public class EndOfDayModel
    {
		public int eod_id { get; set; }
		public DateTime eod_Date { get; set; }
		public int UserID { get; set; }
		public int InvTotal { get; set; }
		public decimal InvoiceAmount { get; set; }
		public int PaymentTotal { get; set; }
		public decimal PaymentAmount { get; set; }
		public bool IsActive { get; set; }
	}
}
