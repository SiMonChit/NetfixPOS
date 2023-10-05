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
    public class SupplierDAL : DataControllerBase, ISupplier
    {
        readonly SupplierQuery query;
        public SupplierDAL()
        {
            query = new SupplierQuery();
        }
        public int Delete(int id)
        {
            
            Command = new SqlCommand(query.Delete(), Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("SupplierId", id);

                Connection.Open();
                return Command.ExecuteNonQuery();
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

        public int Insert(SupplierModel supplier)
        {
            
            Command = new SqlCommand(query.Insert(), Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("SupplierName", supplier.SupplierName);
                Command.Parameters.AddWithValue("Email", supplier.Email);
                Command.Parameters.AddWithValue("Phone", supplier.Phone);
                Command.Parameters.AddWithValue("CurrentAddress", supplier.CurrentAddress);

                Connection.Open();
                return Command.ExecuteNonQuery();
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

        public int Update(SupplierModel supplier)
        {
            Command = new SqlCommand(query.Update(), Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("SupplierId", supplier.SupplierId);
                Command.Parameters.AddWithValue("SupplierName", supplier.SupplierName);
                Command.Parameters.AddWithValue("Email", supplier.Email);
                Command.Parameters.AddWithValue("Phone", supplier.Phone);
                Command.Parameters.AddWithValue("CurrentAddress", supplier.CurrentAddress);

                Connection.Open();
                return Command.ExecuteNonQuery();
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
        public object GetSupplier(int id)
        {
            Command = new SqlCommand(query.Select(), Connection);
            Command.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            try
            {
                //Command.Parameters.AddWithValue("SupplierId", id);

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
