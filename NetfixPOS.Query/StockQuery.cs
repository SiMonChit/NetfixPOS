using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Query
{
    public class StockQuery
    {
        string query = "";
        public string Insert()
        {
            query = "";
            return query;
        }
        public string Delete()
        {
            query = "UPDATE StockMaster SET Discontinue = 1 WHERE StockId = @StockId";
            return query;
        }
        public string GetStock()
        {
            query = "UPDATE StockMaster SET Discontinue = 1 WHERE StockId = @StockId";
            return query;
        }
    }
}
