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
    public class IncomeDAL : DataControllerBase, IIncome
    {
        IncomeQuery query;
        public IncomeDAL()
        {
            query = new IncomeQuery();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(IncomeModel income)
        {
            Command = new SqlCommand(query.Insert(), Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("In_Description", income.In_Description);
                Command.Parameters.AddWithValue("In_Date", income.In_Date);
                Command.Parameters.AddWithValue("In_Amount", income.In_Amount);
                Command.Parameters.AddWithValue("UserID", income.UserID);

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

        public void Update(IncomeModel income)
        {
            Command = new SqlCommand(query.Update(), Connection);
            Command.CommandType = CommandType.StoredProcedure;

            try
            {
                Command.Parameters.AddWithValue("IncomeId", income.IncomeId);
                Command.Parameters.AddWithValue("In_Description", income.In_Description);
                Command.Parameters.AddWithValue("In_Date", income.In_Date);
                Command.Parameters.AddWithValue("In_Amount", income.In_Amount);
                Command.Parameters.AddWithValue("UserID", income.UserID);

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

        public DataTable GetIncome_List(DateTime month)
        {
            Command = new SqlCommand(query.Select(), Connection);
            Command.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            try
            {
                Command.Parameters.AddWithValue("In_Date", month);

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

        public DataTable GetIncome_ListByDate(DateTime fromDate, DateTime toDate)
        {
            Command = new SqlCommand(query.SelectByDate(), Connection);
            Command.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            try
            {
                Command.Parameters.AddWithValue("fromDate", fromDate);
                Command.Parameters.AddWithValue("toDate", toDate);

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
