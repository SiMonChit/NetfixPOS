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
                return query = "SELECT * FROM Category WHERE CategoryType=@CategoryType AND IsActive=1 ORDER BY CategoryId";
            }
            else
            {
                return query = "SELECT * FROM Category WHERE CategoryId = @CategoryId AND IsActive=1 ORDER BY CategoryId";
            }
            
        }
        public string SelectAll()
        {
            return query = "SELECT * FROM Category WHERE IsActive=1 ORDER BY CategoryId";
        }
    }
}
