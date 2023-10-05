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
    public class EndOfDayDAL : DataControllerBase, IEndOfDay
    {
        public int Insert(EndOfDayModel emdOfDay)
        {
            string query = "INSERT tbl_GE_EndOfDate VALUES(@eod_Date, @UserID, @InvTotal, @InvoiceAmount, @PaymentTotal, @PaymentAmount, 1)";
            Command = new SqlCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            int returnvalue = 0;
            try
            {
                Command.Parameters.AddWithValue("eod_Date", emdOfDay.eod_Date);
                Command.Parameters.AddWithValue("UserID", emdOfDay.UserID);
                Command.Parameters.AddWithValue("InvTotal", emdOfDay.InvTotal);
                Command.Parameters.AddWithValue("InvoiceAmount", emdOfDay.InvoiceAmount);
                Command.Parameters.AddWithValue("PaymentTotal", emdOfDay.PaymentTotal);
                Command.Parameters.AddWithValue("PaymentAmount", emdOfDay.PaymentAmount);

                Connection.Open();
                returnvalue = Command.ExecuteNonQuery();
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
            return returnvalue;
        }
        public DataTable GetListForEnd(int userid, DateTime saledate)
        {
            Command = new SqlCommand("EndOfDay_SelectForEnd", Connection);
            Command.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            try
            {
                Command.Parameters.AddWithValue("UserID", userid);
                Command.Parameters.AddWithValue("SaleDate", saledate);
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

        public DataTable GetSaleDetailForDayEnd(int userid, DateTime saledate)
        {
            Command = new SqlCommand("EndOfDay_SelectForEnd", Connection);
            Command.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            try
            {
                Command.Parameters.AddWithValue("UserID", userid);
                Command.Parameters.AddWithValue("SaleDate", saledate);
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
        public DataTable GetListEndOfDay(int userid)
        {
            Command = new SqlCommand("EndOfDay_GetListEndOfDay", Connection);
            Command.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            try
            {
                Command.Parameters.AddWithValue("UserID", userid);
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
