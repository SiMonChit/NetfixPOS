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
    public class CustomerDAL : DataControllerBase, ICustomer
    {
        public void Delete(int id)
        {
            string query = "UPDATE tbl_Customer SET IsActive = 0 WHERE CustomerId = @CustomerId";
            Command = new SqlCommand(query, Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("CustomerId", id);

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

        public void Insert(CustomerModel customer)
        {
            string query = "INSERT tbl_Customer VALUES(@CustomerName, @Email, @Phone, @CurrentAddress, @IsDefault, 1)";
            Command = new SqlCommand(query, Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("CustomerName", customer.CustomerName);
                Command.Parameters.AddWithValue("Email", customer.Email);
                Command.Parameters.AddWithValue("Phone", customer.Phone);
                Command.Parameters.AddWithValue("CurrentAddress", customer.CurrentAddress);
                Command.Parameters.AddWithValue("IsDefault", customer.IsDefault);

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

        public void Update(CustomerModel customer)
        {
            string query = "UPDATE tbl_Customer SET CustomerName = @CustomerName, Email = @Email, Phone = @Phone, CurrentAddress = @CurrentAddress," +
                "IsDefault = @IsDefault WHERE CustomerId = @CustomerId";
            Command = new SqlCommand(query, Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("CustomerId", customer.CustomerId);
                Command.Parameters.AddWithValue("CustomerName", customer.CustomerName);
                Command.Parameters.AddWithValue("Email", customer.Email);
                Command.Parameters.AddWithValue("Phone", customer.Phone);
                Command.Parameters.AddWithValue("CurrentAddress", customer.CurrentAddress);
                Command.Parameters.AddWithValue("IsDefault", customer.IsDefault);

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

        public DataRow GetDefaultCustomer()
        {
            Command = new SqlCommand("SELECT * FROM tbl_Customer WHERE IsDefault = 1", Connection);
            //Command.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            try
            {
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
            return dt.Rows[0];
        }
        public DataTable GetCustomer(int id)
        {
            Command = new SqlCommand("Customer_Select", Connection);
            Command.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            try
            {
                Command.Parameters.AddWithValue("CustomerId", id);

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
