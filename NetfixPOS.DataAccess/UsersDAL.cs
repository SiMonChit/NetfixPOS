using NetfixPOS.DataAccess.Interface;
using NetfixPOS.Models;
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
    public class UsersDAL : DataControllerBase, IUsers
    {
        public void Delete(int id)
        {
            string query = "UPDATE Users SET IsActive = 0 WHERE UserID = @UserID";
            Command = new SqlCommand(query, Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("UserID", id);

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

        public void Insert(UsersModel users)
        {
            string query = "INSERT Users VALUES(@UserName, @UserImage, @Email, @Password_Salt, @Password,0, 1)";
            Command = new SqlCommand(query, Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("UserName", users.UserName);
                Command.Parameters.AddWithValue("UserImage", users.UserImage);
                Command.Parameters.AddWithValue("Email", users.Email);
                Command.Parameters.AddWithValue("Password", users.Password);
                Command.Parameters.AddWithValue("Password_Salt", users.Password_Salt);
                
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

        public void Update(UsersModel users)
        {
            string query = "UPDATE Users SET UserName = @UserName, serImagem = @serImagem, Email = @Email, Password = @Password, Password_Salt = @Password_Salt" +
                " WHERE UserID = @UserID";
            Command = new SqlCommand(query, Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("UserID", users.UserID);
                Command.Parameters.AddWithValue("UserName", users.UserName);
                Command.Parameters.AddWithValue("UserImage", users.UserImage);
                Command.Parameters.AddWithValue("Email", users.Email);
                Command.Parameters.AddWithValue("Password", users.Password);
                Command.Parameters.AddWithValue("Password_Salt", users.Password_Salt);
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

        public DataTable GetUsers(int id)
        {
            Command = new SqlCommand("UsersSelect", Connection);
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

        public ds_Users.UsersRow UsersLogin(string UserName, string Password)
        {
            ds_Users.UsersDataTable datatable = new ds_Users.UsersDataTable();

            Command = new SqlCommand("UsersLogin", Connection);
            Command.CommandType = CommandType.StoredProcedure;

            try
            {
                Command.Parameters.AddWithValue("UserName", UserName);
                Command.Parameters.AddWithValue("Password", Password);
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
            if (datatable.Rows.Count > 0)
                return datatable[0];
            else return null;
        }
        public void UsersLogout(int UserId)
        {
            string query = "UPDATE Users SET IsLogin = 0 WHERE UserID = @UserID";
            Command = new SqlCommand(query, Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("UserID", UserId);
               
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
    }
}
