using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Models
{
    public class PaymentModel
    {
		public int PaymentId { get; set; }
		public int SaleTypeId { get; set; }
		public string SaleId { get; set; }
		public DateTime PaySlipDate { get; set; }
		public string PaySlipNo { get; set; }
		public decimal PaidAmount { get; set; }
		public string PaidFrom { get; set; }

		public int UserID { get; set; }
		public decimal InvAmount { get; set; }
		public bool IsActive { get; set; }
	}
}
