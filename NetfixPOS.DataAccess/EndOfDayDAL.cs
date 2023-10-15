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
    public class EndOfDayDAL : DataControllerBase, IEndOfDay
    {
        private EndOfDayQuery query;
        public EndOfDayDAL()
        {
            query = new EndOfDayQuery();
        }
        public int Insert(EndOfDayModel emdOfDay, int ShopId)
        {
            Command = new SqlCommand(query.Insert(), Connection);
            Command.CommandType = CommandType.Text;
            int returnvalue = 0;
            try
            {
                
                Command.Parameters.AddWithValue("UserID", emdOfDay.UserID);
                Command.Parameters.AddWithValue("eod_desc", emdOfDay.eod_desc);
                Command.Parameters.AddWithValue("VoucherQty", emdOfDay.VoucherQty);
                Command.Parameters.AddWithValue("VoucherAmount", emdOfDay.VoucherAmount);
                Command.Parameters.AddWithValue("eod_Date", emdOfDay.eod_Date);
                Command.Parameters.AddWithValue("ShopId", ShopId);

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
                Command.Parameters.AddWithValue("UserID", 1);
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

        public DataTable CheckEndOfDay(DateTime nowdate)
        {
            Command = new SqlCommand(query.IsEndOfDay(), Connection);
            Command.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            try
            {
                Command.Parameters.AddWithValue("eod_Date", nowdate);
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
