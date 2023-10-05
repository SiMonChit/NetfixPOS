using NetfixPOS.Models;
using NetfixPOS.Query;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.DataAccess
{
    public class ConversionDAL : DataControllerBase
    {
        public void InsertConvension(string stockId, dsNewSetup.ConversionDataTable convDt, SqlConnection connection, SqlTransaction transaction)
        {
            string sqlcmd = "Conversion_Insert";

            SqlCommand command = null;

            try
            {

                foreach (dsNewSetup.ConversionRow row in convDt)
                {
                    command = new SqlCommand(sqlcmd, connection, transaction);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("StockId", stockId);
                    command.Parameters.AddWithValue("UnitId", row.UnitId);
                    command.Parameters.AddWithValue("ParentId", row.ParentId);
                    command.Parameters.AddWithValue("ConvertQty", row.ConvertQty);
                    command.Parameters.AddWithValue("RetailPrice", row.RetailPrice);
                    command.Parameters.AddWithValue("WholesalePrice", row.WholesalePrice);
                    command.Parameters.AddWithValue("Serial", row.Serial);
                    command.Parameters.AddWithValue("InvQty", row.InvQty);
                    command.Parameters.AddWithValue("PurchasePrice", row.PurchasePrice);
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateConvension(dsNewSetup.ConversionDataTable convDt, SqlConnection connection, SqlTransaction transaction)
        {
            string sqlcmd = "Conversion_Update";

            try
            {

                foreach (dsNewSetup.ConversionRow row in convDt)
                {
                    Command = new SqlCommand(sqlcmd, connection, transaction);
                    Command.CommandType = CommandType.StoredProcedure;

                    if (row.ConversionId == null)
                    {
                        Command.Parameters.AddWithValue("ConversionId", DBNull.Value);
                    }
                    else
                    {
                        Command.Parameters.AddWithValue("ConversionId", row.ConversionId);
                    }

                    Command.Parameters.AddWithValue("StockId", row.StockId);
                    Command.Parameters.AddWithValue("UnitId", row.UnitId);
                    Command.Parameters.AddWithValue("ParentId", row.ParentId);
                    Command.Parameters.AddWithValue("ConvertQty", row.ConvertQty);
                    Command.Parameters.AddWithValue("RetailPrice", row.RetailPrice);
                    Command.Parameters.AddWithValue("WholesalePrice", row.WholesalePrice);
                    Command.Parameters.AddWithValue("Serial", row.Serial);
                    Command.Parameters.AddWithValue("InvQty", row.InvQty);
                    Command.Parameters.AddWithValue("PurchasePrice", row.PurchasePrice);
                    Command.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteConvension(string stockId, SqlConnection connection, SqlTransaction transaction)
        {
            ConversionQuery query = new ConversionQuery();
            Command = new SqlCommand(query.Delete(), connection, transaction);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("StockId", stockId);
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public dsNewSetup.SelectConversionDataTable ConversionSelectByStockId(string key)
        {
            string sqlcmd = "Conversion_SelectByStockId";

            dsNewSetup.SelectConversionDataTable dataTable = new dsNewSetup.SelectConversionDataTable();
            Command = new SqlCommand(sqlcmd, Connection);
            Command.CommandType = CommandType.StoredProcedure;

            Command.Parameters.AddWithValue("@StockId", key);

            try
            {
                if (Connection.State == ConnectionState.Closed) Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Command);

                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open) Connection.Close();
            }

            return dataTable;
        }
    }
}
