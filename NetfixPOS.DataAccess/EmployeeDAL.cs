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
    public class EmployeeDAL : DataControllerBase, IEmployee
    {
        public void Delete(int id)
        {
            string query = "UPDATE tbl_Employee SET IsActive = 0 WHERE EmpId = @EmpId";
            Command = new SqlCommand(query, Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("EmpId", id);

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

        public void Insert(EmployeeModel employee)
        {
            string query = "INSERT tbl_Employee VALUES(@EnrollNumber, @EmpName, @DepartmentId, @EmpImage, @Gender, @PhoneNo, @BirthPlace, @JoinDate, 1)";
            Command = new SqlCommand(query, Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("EnrollNumber", employee.EnrollNumber);
                Command.Parameters.AddWithValue("EmpName", employee.EmpName);
                Command.Parameters.AddWithValue("DepartmentId", employee.DepartmentId);
                Command.Parameters.AddWithValue("EmpImage", employee.EmpImage);
                Command.Parameters.AddWithValue("Gender", employee.Gender);
                Command.Parameters.AddWithValue("PhoneNo", employee.PhoneNo);
                Command.Parameters.AddWithValue("BirthPlace", employee.BirthPlace);
                Command.Parameters.AddWithValue("JoinDate", employee.JoinDate);

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

        public void Update(EmployeeModel employee)
        {
            string query = "UPDATE tbl_Employee SET EnrollNumber = @EnrollNumber, EmpName = @EmpName, DepartmentId = @DepartmentId, EmpImage = @EmpImage, Gender = @Gender, " +
                "PhoneNo = @PhoneNo, BirthPlace = @BirthPlace, JoinDate = @JoinDate WHERE EmpId = @EmpId";
            Command = new SqlCommand(query, Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("EmpId", employee.EmpId);
                Command.Parameters.AddWithValue("EnrollNumber", employee.EnrollNumber);
                Command.Parameters.AddWithValue("EmpName", employee.EmpName);
                Command.Parameters.AddWithValue("DepartmentId", employee.DepartmentId);
                Command.Parameters.AddWithValue("EmpImage", employee.EmpImage);
                Command.Parameters.AddWithValue("Gender", employee.Gender);
                Command.Parameters.AddWithValue("PhoneNo", employee.PhoneNo);
                Command.Parameters.AddWithValue("BirthPlace", employee.BirthPlace);
                Command.Parameters.AddWithValue("JoinDate", employee.JoinDate);

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

        //Get by departmentid or all emp list
        public DataTable GetEmpList(int deptId)
        {
            Command = new SqlCommand("Employee_Select", Connection);
            Command.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            try
            {
                Command.Parameters.AddWithValue("deptId", deptId);

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
