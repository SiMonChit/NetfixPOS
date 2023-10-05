using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Query
{
    public class ExpenseQuery
    {
        public string Insert()
        {
            string query = "INSERT tbl_Expense VALUES(@Ex_Description, @Ex_Date, @Ex_Amount,1, @UserID)";
            return query;
        }
        public string Update()
        {
            string query = "UPDATE tbl_Expense SET Ex_Description = @Ex_Description, Ex_Date = @Ex_Date, Ex_Amount = @Ex_Amount, " +
                "UserID = @UserID WHERE ExpenseId = @ExpenseId";
            return query;
        }
        public string Delete()
        {
            string query = "UPDATE tbl_Expense SET IsActive = 0 WHERE ExpenseId = @ExpenseId";
            return query;
        }
        public string Select()
        {
            string qeury = "SELECT * FROM tbl_Expense WHERE MONTH(Ex_Date) = MONTH(@Ex_Date) AND YEAR(Ex_Date) = YEAR(@Ex_Date) AND IsActive = 1";
            return qeury;
        }
    }
}
