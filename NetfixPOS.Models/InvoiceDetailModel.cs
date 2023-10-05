using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Models
{
    public class InvoiceDetailModel
    {
		public int SaleDetailId { get; set; }

		public string SaleId{ get; set; }
		public string StockId{ get; set; }
		public int CategoryID { get; set; }
		public string ConvensionId{ get; set; }
		public int Serial{ get; set; }
		public decimal Qty{ get; set; }
		public decimal SalePrice{ get; set; }
		public decimal Discount{ get; set; }
		public decimal Amount{ get; set; }
		public bool IsFOC{ get; set; }
		public bool IsActive{ get; set; }
    }
}
