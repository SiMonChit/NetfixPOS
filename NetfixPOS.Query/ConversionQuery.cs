using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Query
{
    public class ConversionQuery
    {
        string query = "";
        public string Delete()
        {
            return query = "DELETE FROM Conversion WHERE StockId = @StockId";
        }
    }
}
