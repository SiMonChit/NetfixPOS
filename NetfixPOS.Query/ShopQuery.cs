using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Query
{
    public class ShopQuery
    {
        private string query = "";
        public string GetShopName()
        {
            return query = "SELECT * FROM ShopInfo WHERE IsActive = 1 AND ShopId = @ShopId";
        }
        public string Select()
        {
            return query = "SELECT * FROM ShopInfo WHERE IsActive = 1";
        }
    }
}
