using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Query
{
    public class AppInfoQuery
    {
        string query = "";
        public string Insert()
        {
            return query = "INSERT tbl_GE_AppInfo VALUES(@ShopId, @SaleDate, @ActivateKey, @ServiceTax, @ServiceCharges, 1, @InvDiscount)";
        }
        public string Update()
        {
            return query = "UPDATE tbl_GE_AppInfo SET SaleDate  = @SaleDate, ServiceTax = @ServiceTax, ServiceCharges = @ServiceCharges, InvDiscount = @InvDiscount WHERE General_Id = @General_Id";
        }
    }
}
