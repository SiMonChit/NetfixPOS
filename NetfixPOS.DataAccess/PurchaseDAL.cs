using NetfixPOS.DataAccess.Interface;
using NetfixPOS.Models.DataSetFile;
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
    public class PurchaseDAL : DataControllerBase, IPurchase
    {
        PurchaseQuery query;
        public PurchaseDAL()
        {
            query = new PurchaseQuery();
        }
        public int Delete(int PurchaseId)
        {
            Command = new SqlCommand(query.Delete(), Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("PurchaseId", PurchaseId);
                

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

        public int Insert(ds_Purchase.tbl_PurchaseRow purchaseRow)
        {
            Command = new SqlCommand(query.Insert(), Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("StockId", purchaseRow.StockId);
                Command.Parameters.AddWithValue("StockName", purchaseRow.StockName);
                Command.Parameters.AddWithValue("PurchasePrice", purchaseRow.PurchasePrice);
                Command.Parameters.AddWithValue("Qty", purchaseRow.Qty);
                Command.Parameters.AddWithValue("Amount", purchaseRow.Amount);
                Command.Parameters.AddWithValue("Pur_Date", purchaseRow.Pur_Date);
                Command.Parameters.AddWithValue("UserID", purchaseRow.UserID);

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

        public int Update(ds_Purchase.tbl_PurchaseRow purchaseRow)
        {
            Command = new SqlCommand(query.Update(), Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("PurchaseId", purchaseRow.PurchaseId);
                Command.Parameters.AddWithValue("StockId", purchaseRow.StockId);
                Command.Parameters.AddWithValue("StockName", purchaseRow.StockName);
                Command.Parameters.AddWithValue("PurchasePrice", purchaseRow.PurchasePrice);
                Command.Parameters.AddWithValue("Qty", purchaseRow.Qty);
                Command.Parameters.AddWithValue("Amount", purchaseRow.Amount);
                Command.Parameters.AddWithValue("Pur_Date", purchaseRow.Pur_Date);
                Command.Parameters.AddWithValue("UserID", purchaseRow.UserID);
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

        public DataTable GetPurchaseList(DateTime pur_date)
        {
            Command = new SqlCommand(query.Select(pur_date), Connection);
            Command.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            try
            {
                Command.Parameters.AddWithValue("Pur_Date", pur_date);

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
