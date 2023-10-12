using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Query
{
    public class EndOfDayQuery
    {
        private string query = "";
        public string Insert()
        {
            query = "INSERT tbl_GE_EndOfDate VALUES(@UserID, @eod_desc, @VoucherQty, @VoucherAmount, @eod_Date, 1)";
            return query;
        }
        public string IsEndOfDay()
        {
            return query = "SELECT * FROM tbl_GE_EndOfDate WHERE CAST(eod_Date AS DATE) = CAST(@eod_Date AS DATE)";
        }
    }
}
