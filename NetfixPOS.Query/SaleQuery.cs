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
