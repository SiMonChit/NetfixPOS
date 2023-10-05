using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Query
{
    public class SupplierQuery
    {
        string query = "";
        public string Insert()
        {
            query = "INSERT tbl_Supplier VALUES(@SupplierName, @Email, @Phone, @CurrentAddress, 1)";
            return query;
        }
        public string Update()
        {
            query = "UPDATE tbl_Supplier SET SupplierName = @SupplierName, Email = @Email, Phone = @Phone, CurrentAddress = @CurrentAddress";
            query +=" WHERE SupplierId = @SupplierId";
            return query;
        }
        public string Delete()
        {
            query = "UPDATE tbl_Supplier SET IsActive = 0 WHERE SupplierId = @SupplierId";
            return query;
        }
        public string Select()
        {
            query = "SELECT * FROM tbl_Supplier WHERE IsActive = 1";
            return query;
        }
    }
}
