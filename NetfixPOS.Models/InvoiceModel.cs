using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Models
{
    public class InvoiceModel
    {
		public string SaleId { get; set; }
		public int TableId { get; set; }
		public int RoomId { get; set; }
		public int CustomerId { get; set; }
		public int UserID { get; set; }
		public int SaleTypeId { get; set; }
		public string InvNo { get; set; }
		public DateTime InvDate { get; set; }
		public string Remark { get; set; }
		public decimal GrandTotal { get; set; }
		public decimal TotalAmount { get; set; }
		public decimal DiscountAmount { get; set; }
		public decimal AdvanceAmount { get; set; }
		public decimal BalanceAmount { get; set; }
		public decimal DueAmount { get; set; }
		public decimal DeliveryFee { get; set; }
		public decimal C_tax { get; set; }
		public bool IsFOC { get; set; }
		public bool IsActive { get; set; }
		public string InvoiceStatus { get; set; }
		public string Singer { get; set; }
		public decimal ServiceCharges { get; set; }
	}
}
