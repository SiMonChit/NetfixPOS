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
    public class ExpenseDAL : DataControllerBase, IExpense
    {
        ExpenseQuery query;
        public ExpenseDAL()
        {
            query = new ExpenseQuery();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(ExpenseModel expense)
        {
            Command = new SqlCommand(query.Insert(), Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("Ex_Description", expense.Ex_Description);
                Command.Parameters.AddWithValue("Ex_Date", expense.Ex_Date);
                Command.Parameters.AddWithValue("Ex_Amount", expense.Ex_Amount);
                Command.Parameters.AddWithValue("UserID", expense.UserID);

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

        public void Update(ExpenseModel expense)
        {
            Command = new SqlCommand(query.Update(), Connection);
            Command.CommandType = CommandType.StoredProcedure;

            try
            {
                Command.Parameters.AddWithValue("ExpenseId", expense.ExpenseId);
                Command.Parameters.AddWithValue("Ex_Description", expense.Ex_Description);
                Command.Parameters.AddWithValue("Ex_Date", expense.Ex_Date);
                Command.Parameters.AddWithValue("Ex_Amount", expense.Ex_Amount);
                Command.Parameters.AddWithValue("UserID", expense.UserID);

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

        public DataTable GetExpense_List(DateTime month)
        {
            Command = new SqlCommand(query.Select(), Connection);
            Command.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            try
            {
                Command.Parameters.AddWithValue("Ex_Date", month);

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

        public DataTable GetExpense_ListByDate(DateTime fromDate, DateTime toDate)
        {
            Command = new SqlCommand("Expense_ListByDate", Connection);
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
