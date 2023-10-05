using NetfixPOS.DataAccess.Interface;
using NetfixPOS.Models.DataSetFile;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.DataAccess
{
    public class UserPermissionDAL:DataControllerBase, IPermission
    {
        public DataTable GetUserPermissionList(int id)
        {
            Command = new SqlCommand("UserPermission_Select", Connection);
            Command.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            try
            {
                Command.Parameters.AddWithValue("UserID", id);
                
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

        public void Insert(ds_Permission.UserPermissionRow row)
        {
            try
            {
                string query = "UserPermission_Insert";
                Command = new SqlCommand(query, Connection);
                Command.CommandType = CommandType.StoredProcedure;

                Command.Parameters.AddWithValue("PermissionID", row.PermissionID);
                Command.Parameters.AddWithValue("ControlId", row.ControlId);
                Command.Parameters.AddWithValue("UserID", row.UserID);
                Command.Parameters.AddWithValue("IsSave", row.IsSave);
                Command.Parameters.AddWithValue("IsUpdate", row.IsUpdate);
                Command.Parameters.AddWithValue("IsDelete", row.IsDelete);
                Command.Parameters.AddWithValue("IsView", row.IsView);
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

        public int Update(ds_Permission.UserPermissionRow row)
        {
            try
            {
                string query = "UserPermission_Insert";
                Command = new SqlCommand(query, Connection);
                Command.CommandType = CommandType.StoredProcedure;

                Command.Parameters.AddWithValue("PermissionID", row.PermissionID);
                Command.Parameters.AddWithValue("ControlId", row.ControlId);
                Command.Parameters.AddWithValue("UserID", row.UserID);
                Command.Parameters.AddWithValue("IsSave", row.IsSave);
                Command.Parameters.AddWithValue("IsUpdate", row.IsUpdate);
                Command.Parameters.AddWithValue("IsDelete", row.IsDelete);
                Command.Parameters.AddWithValue("IsView", row.IsView);
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
        public ds_Permission.UserPermissionDataTable GetPermission(int userid)
        {
            ds_Permission.UserPermissionDataTable datatable = new ds_Permission.UserPermissionDataTable();

            Command = new SqlCommand("UserPermission_SelectByUserID", Connection);
            Command.CommandType = CommandType.StoredProcedure;

            try
            {
                Command.Parameters.AddWithValue("UserID", userid);
               
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = Command;
                dataAdapter.Fill(datatable);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Close();
            }
            return datatable;
        }
    }
}
