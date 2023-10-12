using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Query
{
    public class PurchaseQuery
    {
        private string query = "";
        public string Insert()
        {
            query = "INSERT tbl_Purchase VALUES(@StockId, @StockName, @PurchasePrice, @Qty, @Amount, @Pur_Date, @UserID, 1)";
            return query;
        }
        public string Update()
        {
            query = "UPDATE tbl_Purchase SET StockId = @StockId, StockName = @StockName, PurchasePrice = @PurchasePrice,";
            query += "Qty = @Qty, Amount = @Amount, Pur_Date = @Pur_Date, UserID = @UserID ";
            query += "WHERE PurchaseId = @PurchaseId";

            return query;
        }
        public string Delete()
        {
            return query = "UPDATE tbl_Purchase SET IsActive = 0 WHERE PurchaseId = @PurchaseId";
        }
        public string Select(DateTime pur_date)
        {
            query = "SELECT pc.*, UserName FROM tbl_Purchase pc INNER JOIN Users ON Users.UserID = pc.UserID ";
            query += "WHERE Pur_Date = @Pur_Date AND pc.IsActive = 1";
            return query;
        }
        public string SelectByDate()
        {
            query = "SELECT pc.*, UserName FROM tbl_Purchase pc INNER JOIN Users ON Users.UserID = pc.UserID ";
            query += "WHERE CAST(Pur_Date AS DATE) BETWEEN CAST(@fromDate AS DATE) AND CAST(@toDate AS DATE) AND pc.IsActive = 1";
            return query;
        }
    }
}
