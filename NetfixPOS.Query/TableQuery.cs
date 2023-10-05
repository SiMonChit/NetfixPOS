using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Query
{
    public class TableQuery
    {
        string query = "";
        public string Insert()
        {
            query = "INSERT tbl_Table VALUES(@TableNo, @TableName, @CompanyId, @ModifiedDate, 0, 1, @IsDefault)";
            return query;
        }
        public string Update()
        {
            query = "UPDATE tbl_Table SET TableNo = @TableNo, TableName = @TableName, CompanyId = @CompanyId," +
                " ModifiedDate = @ModifiedDate, IsDefault= @IsDefault WHERE TableID = @TableID";
            return query;
        }

        public string Delete()
        {
            query = "UPDATE tbl_Table SET IsDeleted = 1 WHERE TableID = @TableID";
            return query;
        }
        public string Select(int TableID)
        {
            if (TableID == 0)
            {
                query = "SELECT TableID, TableNo, TableName, CompanyID, ModifiedDate, IsDeleted, IsAvailable FROM dbo.tbl_Table WHERE IsDeleted = 0 ORDER BY TableID";
            }
            else
            {
                query = "SELECT TableID, TableNo, TableName, CompanyID, ModifiedDate, IsDeleted, IsAvailable FROM dbo.tbl_Table WHERE(TableID = @TableID) ORDER BY TableID";
            }
            return query;
        }
    }
}
