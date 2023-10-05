using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Models
{
    public class TableModel
    {
        public int TableID { get; set; }
        public string TableNo { get; set; }
        public string TableName { get; set; }
        public int CompanyId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsDefault { get; set; }
    }
}
