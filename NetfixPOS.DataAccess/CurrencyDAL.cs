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
    public class CurrencyDAL : DataControllerBase, ICurrency
    {
        public void Delete(int id)
        {
            string query = "DELETE FROM SaleCurrency WHERE CurrencyId = @CurrencyId";
            Command = new SqlCommand(query, Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("CurrencyId", id);

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

        public void Insert(CurrencyModel currency)
        {
            string query = "INSERT SaleCurrency VALUES(@Currency, @Symbol, @IsDefault)";
            Command = new SqlCommand(query, Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("Currency", currency.Currency);
                Command.Parameters.AddWithValue("Symbol", currency.Symbol);
                Command.Parameters.AddWithValue("IsDefault", currency.IsDefault);
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

        public void Update(CurrencyModel currency)
        {
            string query = "UPDATE SaleCurrency SET Currency = @Currency, Symbol = @Symbol, IsDefault = @IsDefault WHERE CurrencyId = @CurrencyId";
            Command = new SqlCommand(query, Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("CurrencyId", currency.CurrencyId);
                Command.Parameters.AddWithValue("Currency", currency.Currency);
                Command.Parameters.AddWithValue("Symbol", currency.Symbol);
                Command.Parameters.AddWithValue("IsDefault", currency.IsDefault);
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
        public DataRow GetDefaultCurrency()
        {
            string sqlcmd = @"SELECT * FROM Currency WHERE IsDefault='True'";
            DataTable dataTable = new DataTable();

            Command = new SqlCommand(sqlcmd, Connection);
            try
            {

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = Command;
                dataAdapter.Fill(dataTable);
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

            return dataTable.Rows[0];
        }
        public DataTable GetCurrency(int id)
        {
            Command = new SqlCommand("SaleCurrency_Select", Connection);
            Command.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            try
            {
                Command.Parameters.AddWithValue("CurrencyId", id);

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
