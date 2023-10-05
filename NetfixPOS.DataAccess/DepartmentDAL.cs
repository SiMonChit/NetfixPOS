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
    public class DepartmentDAL : DataControllerBase, IDepartment
    {
        public void Delete(int id)
        {
            string query = "UPDATE tbl_Department SET IsActive = 0 WHERE DepartmentId = @DepartmentId";
            Command = new SqlCommand(query, Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("DepartmentId", id);

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

        public void Insert(DepartmentModel department)
        {
            string query = "INSERT tbl_Department VALUES(@DepartmentName, @CreatedDate, 1)";
            Command = new SqlCommand(query, Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("DepartmentName", department.DepartmentName);
                Command.Parameters.AddWithValue("CreatedDate", department.CreatedDate);
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

        public void Update(DepartmentModel department)
        {
            string query = "UPDATE tbl_Department SET DepartmentName = @DepartmentName, CreatedDate = @CreatedDate WHERE DepartmentId = @DepartmentId";
            Command = new SqlCommand(query, Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("DepartmentId", department.DepartmentId);
                Command.Parameters.AddWithValue("DepartmentName", department.DepartmentName);
                Command.Parameters.AddWithValue("CreatedDate", department.CreatedDate);
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

        public DataTable GetDepartment(int id)
        {
            Command = new SqlCommand("Department_Select", Connection);
            Command.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            try
            {
                Command.Parameters.AddWithValue("DepartmentId", id);

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
