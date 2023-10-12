using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Query
{
    public class DamageQuery
    {
        private string query = "";
        public string Damage_ListByDate()
        {
            query = "SELECT tbl_Damage.*, UserName FROM tbl_Damage ";
            query += "INNER JOIN Users ON Users.UserID = tbl_Damage.UserID WHERE CAST(Dmg_Date AS DATE) BETWEEN CAST(@fromDate AS DATE) AND CAST(@toDate AS DATE)";
            return query;
        }
    }
}
