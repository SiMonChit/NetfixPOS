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
    public class EventLogsDAL:DataControllerBase
    {
        public void AddLog(EventLogsModel eventLogs)
        {
            Command = new SqlCommand("EventLogs_Insert", Connection);
            Command.CommandType = CommandType.StoredProcedure;

            try
            {
                Command.Parameters.AddWithValue("LogType", eventLogs.LogType);
                Command.Parameters.AddWithValue("LogDateTime", eventLogs.LogDateTime);
                Command.Parameters.AddWithValue("Source", eventLogs.Source);
                Command.Parameters.AddWithValue("LogMessage", eventLogs.LogMessage);
                Command.Parameters.AddWithValue("ErrMessage", eventLogs.ErrMessage);
                Command.Parameters.AddWithValue("LocalIP", eventLogs.LocalIP);

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
        public DataTable ReadLog(DateTime fromDate, DateTime toDate)
        {
            Command = new SqlCommand("EventLogs_Read", Connection);
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
        public void ClearLogs(DateTime clearDate)
        {

        }
    }
}
