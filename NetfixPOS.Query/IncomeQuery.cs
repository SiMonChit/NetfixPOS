using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Query
{
    public class IncomeQuery
    {
        string query = "";
        public string Insert()
        {
            query = "INSERT tbl_Income VALUES(@In_Description, @In_Date, @In_Amount,1, @UserID)";
            return query;
        }
        public string Update()
        {
            query = "UPDATE tbl_Income SET In_Description = @In_Description, In_Date = @In_Date, In_Amount = @In_Amount, " +
                 "UserID = @UserID WHERE IncomeId = @IncomeId";
            return query;
        }
        public string Delete()
        {
            query = "";
            return query;
        }
        public string Select()
        {
            query = "SELECT tbl_Income.*, Users.UserName FROM tbl_Income INNER JOIN Users ON tbl_Income.UserID = Users.UserID";
            query += "WHERE MONTH(In_Date) = MONTH(@In_Date) AND YEAR(In_Date) = YEAR(@In_Date) AND tbl_Income.IsActive = 1";
            return query;
        }
        public string SelectByDate()
        {
            query = "SELECT tbl_Income.*, Users.UserName FROM   tbl_Income INNER JOIN Users ON tbl_Income.UserID = Users.UserID";
            query += "WHERE In_Date BETWEEN CAST(@fromDate AS NVARCHAR(20)) AND CAST(@toDate AS NVARCHAR(20)) AND tbl_Income.IsActive = 1";
            return query;
        }
    }
}
