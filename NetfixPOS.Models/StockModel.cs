using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Models
{
    public class StockModel
    {
        public string StockId { get; set; }
        public string StockCode { get; set; }
        public string StockName { get; set; }
        public int CategoryId { get; set; }
        public decimal Minqty { get; set; }
        public decimal Maxqty { get; set; }
        public int MinUnitId { get; set; }
        public int MaxUnitId { get; set; }
        public int SaleCurrencyId { get; set; }
        public bool Discontinue { get; set; }
        public int DefaultUnit { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public Byte[] StockIcon { get; set; }
        public DateTime ModifiedDate { get; set; }
        public decimal InQty { get; set; }
        public bool IsStore { get; set; }
    }
}
