using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Query
{
    public class SaleQuery
    {
        string query = "";
        public string SelectHeaderRow()
        {
            query = "SELECT * FROM SaleHeader WHERE SaleId = @SaleId AND IsActive=1";
            return query;
        }
        public string SelectSaleItem()
        {
            query = "SELECT * FROM SaleDetail WHERE SaleId = @SaleId AND IsActive=1";
            return query;
        }
    }
}
