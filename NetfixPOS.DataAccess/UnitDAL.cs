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
    public class UnitDAL : DataControllerBase, IUnit
    {
        public void Delete(int id)
        {
            string sqlcmd = "UPDATE Unit SET Active =  0 WHERE UnitID = @UnitId";

            Command = new SqlCommand(sqlcmd, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("UnitId", id);
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

        public void Insert(UnitModel unit)
        {
            string sqlcmd = "INSERT Unit VALUES(@UnitName, @DefaultQty, 1)";

            Command = new SqlCommand(sqlcmd, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("UnitName", unit.UnitName);
            Command.Parameters.AddWithValue("DefaultQty", unit.DefaultQty);
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

        public void Update(UnitModel unit)
        {
            string sqlcmd = "UPDATE Unit SET UnitName =  @UnitName, DefaultQty = @DefaultQty WHERE UnitID = @UnitId";

            Command = new SqlCommand(sqlcmd, Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("UnitId", unit.UnitID);
            Command.Parameters.AddWithValue("UnitName", unit.UnitName);
            Command.Parameters.AddWithValue("DefaultQty", unit.DefaultQty);

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

        public DataTable GetUint()
        {
            Command = new SqlCommand("SELECT * FROM Unit WHERE Active=1", Connection);

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
