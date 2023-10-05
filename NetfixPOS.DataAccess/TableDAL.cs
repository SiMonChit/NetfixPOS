using NetfixPOS.DataAccess.Interface;
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
    public class TableDAL : DataControllerBase, ITable
    {
        TableQuery query;
        public TableDAL()
        {
            query = new TableQuery();
        }
        public void Delete(int id)
        {
            Command = new SqlCommand(query.Delete(), Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("TableID", id);

                Connection.Open();
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

        public void Insert(TableModel table)
        {
            Command = new SqlCommand(query.Insert(), Connection);
            Command.CommandType = CommandType.Text;
            try
            {
                Command.Parameters.AddWithValue("TableNo", table.TableNo);
                Command.Parameters.AddWithValue("TableName", table.TableName);
                Command.Parameters.AddWithValue("CompanyId", table.CompanyId);
                Command.Parameters.AddWithValue("ModifiedDate", table.ModifiedDate);
                Command.Parameters.AddWithValue("IsDefault", table.IsDefault);
                Connection.Open();
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

        public void Update(TableModel table)
        {
            Command = new SqlCommand(query.Update(), Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("TableID", table.TableID);
                Command.Parameters.AddWithValue("TableNo", table.TableNo);
                Command.Parameters.AddWithValue("TableName", table.TableName);
                Command.Parameters.AddWithValue("CompanyId", table.CompanyId);
                Command.Parameters.AddWithValue("ModifiedDate", table.ModifiedDate);
                Command.Parameters.AddWithValue("IsDefault", table.IsDefault);
                Connection.Open();
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

        public DataTable GetTable(int id)
        {
            Command = new SqlCommand(query.Select(id), Connection);
            Command.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            try
            {
                Command.Parameters.AddWithValue("TableID", id);

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
