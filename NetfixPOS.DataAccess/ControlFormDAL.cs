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
    public class ControlFormDAL : DataControllerBase, IControlForm
    {
        public int Delete(int id)
        {
            string query = "UPDATE tbl_ControlForm SET IsActive=0 WHERE ControlId = @ControlId";
            Command = new SqlCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            int returnvalue = 0;
            try
            {
                Command.Parameters.AddWithValue("ControlId", id);

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

        public int Insert(ControlFormModel controlForm)
        {
            string query = "INSERT tbl_ControlForm VALUES(@ControlForm, 1)";
            Command = new SqlCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            int returnvalue = 0;
            try
            {
                Command.Parameters.AddWithValue("ControlForm", controlForm.ControlForm);


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

        public int Update(ControlFormModel controlForm)
        {
            string query = "UPDATE tbl_ControlForm SET ControlForm = @ControlForm WHERE ControlId = @ControlId";
            Command = new SqlCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            int returnvalue = 0;
            try
            {
                Command.Parameters.AddWithValue("ControlId", controlForm.ControlId);
                Command.Parameters.AddWithValue("ControlForm", controlForm.ControlForm);

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
        public DataTable GetControlForms(int id)
        {
            Command = new SqlCommand("ControlForm_Select", Connection);
            Command.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            try
            {
                Command.Parameters.AddWithValue("ControlId", id);

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
