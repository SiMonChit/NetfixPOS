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
    public class CategoryDAL : DataControllerBase, ICategory
    {
        CategoryQuery query;
        public CategoryDAL()
        {
            query = new CategoryQuery();
        }
        public void Delete(int id)
        {
            string query = "UPDATE Category SET IsActive = 0 WHERE CategoryId = @CategoryId";
            Command = new SqlCommand(query, Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("CategoryId", id);
                
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

        public void Insert(CategoryModel category)
        {
            string query = "INSERT Category VALUES(@CategoryName, 1,0, @CategoryType)";
            Command = new SqlCommand(query, Connection);
            Command.CommandType = CommandType.Text;
            
            try
            {
                Command.Parameters.AddWithValue("CategoryName", category.CategoryName);
                Command.Parameters.AddWithValue("CategoryType", category.CategoryType);
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

        public void Update(CategoryModel category)
        {
            string query = "UPDATE Category SET CategoryName = @CategoryName, CategoryType = @CategoryType WHERE CategoryId = @CategoryId";
            Command = new SqlCommand(query, Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("CategoryId", category.CategoryId);
                Command.Parameters.AddWithValue("CategoryName", category.CategoryName);
                Command.Parameters.AddWithValue("CategoryType", category.CategoryType);
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

        public DataTable GetCategory(int id)
        {
            Command = new SqlCommand(query.Select(id), Connection);
            Command.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            try
            {
                Command.Parameters.AddWithValue("CategoryId", id);

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
