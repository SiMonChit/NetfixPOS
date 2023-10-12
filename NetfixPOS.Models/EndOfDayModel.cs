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
		public string eod_desc { get; set; }//For description
		public int VoucherQty { get; set; }
		public decimal VoucherAmount { get; set; }
		public bool IsActive { get; set; }
	}
}
