using NetfixPOS.DataAccess.Interface;
using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.DataAccess
{
    public class SaleTypeDAL : DataControllerBase, ISaleType
    {
        public void Delete(int id)
        {
            string sqlcmd = "UPDATE SaleType SET IsActive =  0 WHERE SaleTypeId = @SaleTypeId";

            Command = new SqlCommand(sqlcmd, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("SaleTypeId", id);
            try
            {
                if (Connection.State == ConnectionState.Closed) Connection.Open();

                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                    Connection.Close();
            }
        }

        public void Insert(SaleTypeModel saleType)
        {
            string sqlcmd = "INSERT SaleType VALUES(@SaleTypeName, 1)";

            Command = new SqlCommand(sqlcmd, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("SaleTypeName", saleType.SaleTypeName);

            try
            {
                if (Connection.State == ConnectionState.Closed) Connection.Open();

                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                    Connection.Close();
            }
        }

        public void Update(SaleTypeModel saleType)
        {
            string sqlcmd = "UPDATE SaleType SET SaleTypeName =  @SaleTypeName WHERE SaleTypeId = @SaleTypeId";

            Command = new SqlCommand(sqlcmd, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("SaleTypeId", saleType.SaleTypeId);
            Command.Parameters.AddWithValue("SaleTypeName", saleType.SaleTypeName);

            string key = null;
            try
            {
                if (Connection.State == ConnectionState.Closed) Connection.Open();

                key = Command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                    Connection.Close();
            }
        }

        public DataTable GetSaleType()
        {
            Command = new SqlCommand("SELECT * FROM SaleType WHERE IsActive=1 ORDER BY SaleTypeId", Connection);

            DataTable dt = new DataTable();
            try
            {
                //Command.Parameters.AddWithValue("UnitID", id);

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = Command;
                dataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Close();
            }
            return dt;
        }
    }
}
