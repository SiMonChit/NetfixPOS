using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Query
{
    public class SaleQuery
    {
        string query = "";
        public string SelectHeaderRow()
        {
            query = "SELECT * FROM SaleHeader WHERE SaleId = @SaleId AND IsActive=1";
            return query;
        }
        public string SaleHeaderSelectByDate()
        {
            query = "SELECT SaleHeader.*, UserName FROM SaleHeader INNER JOIN Users ON Users.UserID = SaleHeader.UserID";
            query += "WHERE CAST(InvDate AS DATE) BETWEEN CAST(@fromDate AS DATE) AND  CAST(@toDate AS DATE) AND SaleHeader.IsActive = 1";
            return query;
        }

        //column SHours, NetAmount, TransactionCount
        public string SaleHeaderSelectByHours()
        {
            query = "SELECT  RIGHT('00' + CONVERT(VARCHAR, DATEPART(HOUR, InvDate)), 2) + ':00' AS SHours, SUM(NetAmount) AS NetAmount,COUNT(*) AS TransactionCount";
            query += " FROM SaleHeader A WHERE CAST(A.InvDate AS DATETIME) BETWEEN CAST(@FromDate AS DATE) AND CAST(@ToDate AS DATE)";
            query += " GROUP BY DATEPART(HOUR, InvDate)";
            return query;
        }
        public string SaleHeaderSelectByWeelky()
        {
            query = "SET DATEFIRST 7;";
            query += "SELECT CASE DATEPART(WEEKDAY,InvDate) WHEN 2 THEN 'Monday' WHEN 3 THEN 'Tuesday' WHEN 4 THEN 'Wednesday' WHEN 5 THEN 'Thursday' WHEN 6 THEN 'Friday' WHEN 7 THEN 'Saturday' WHEN 1 THEN 'Sunday' END as DName,";
            query += "SUM(NetAmount) AS NetAmount, COUNT(*) AS TransactionCount FROM SaleHeader S WHERE CAST(InvDate AS DATE) BETWEEN CAST(@FromDate AS DATE) AND CAST(@ToDate AS DATE) AND IsActive = 1 ";
            query += "GROUP BY  DATEPART(WEEKDAY, InvDate) ORDER BY DATEPART(WEEKDAY, InvDate) ASC;";
            return query;
        }
        public string SelectSaleItem()
        {
            query = "SELECT * FROM SaleDetail WHERE SaleId = @SaleId AND IsActive=1";
            return query;
        }
        public string SaleItemDelete()
        {
            query = "UPDATE SaleDetail SET IsActive = 0 WHERE SaleId = @SaleId";
            return query;
        }
        public string GetListForSaleSlip()
        {
            query = "SELECT sh.*, StockId, StockName, SalePrice, Qty, sdt.Discount, Amount, sdt.IsFOC AS IsFOCDetail, ShopImage, ShopName, CurrentAddress, PhoneNo";
            query += " FROM SaleHeader sh INNER JOIN SaleDetail sdt ON sdt.SaleId = sh.SaleId CROSS JOIN ShopInfo WHERE sh.SaleId = @SaleId AND sh.IsActive = 1 AND sdt.IsActive=1";
            return query;
        }

        public string Top10SellingItem()
        {
            query = "Select Top 10 * from ( Select Sum(Amount) as Amount, StockCode, sd.StockName from SaleDetail sd ";
            query += "inner join StockMaster S on sd.StockId = S.StockID where sd.IsActive = 1 Group By S.StockCode, sd.StockName)as A";
            return query;
        }
        public string ShowDataOnDashboard()
        {
            query = "DECLARE @NetAmount NUMERIC(18,0) DECLARE @TotalCash NUMERIC(18,0) DECLARE @TotalCredit NUMERIC(18,0) DECLARE @TotalSaleCount INT";
            query += " SET @NetAmount =(SELECT SUM(NetAmount) FROM SaleHeader WHERE IsActive = 1 AND InvDate = @SaleDate)";
            query += " SET @TotalCash =(SELECT SUM(TotalAmount) FROM SaleHeader WHERE IsActive = 1 AND InvDate = @SaleDate)";
            query += " SET @TotalCredit = (SELECT SUM(TotalAmount) FROM SaleHeader WHERE IsActive = 1 AND InvDate = @SaleDate)";
            query += " SET @TotalSaleCount = (SELECT COUNT(SaleId) FROM SaleHeader WHERE IsActive = 1 AND InvDate = @SaleDate)";
            query += " SELECT ISNULL(@NetAmount,0), ISNULL(@TotalCash,0), ISNULL(@TotalCredit,0), @TotalSaleCount";
            return query;
        }
    }
}
