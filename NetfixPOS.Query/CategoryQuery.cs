using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Query
{
    public class CategoryQuery
    {
        string query = "";
        public string Select(int id)
        {
            if (id == 0)
            {
                return query = "SELECT * FROM Category ORDER BY CategoryId";
            }
            else
            {
                return query = "SELECT * FROM Category WHERE CategoryId = @CategoryId ORDER BY CategoryId";
            }
            
        }
    }
}
