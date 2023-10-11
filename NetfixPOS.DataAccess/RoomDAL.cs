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
    public class RoomDAL : DataControllerBase, IRoom
    {
        RoomQuery query;
        public RoomDAL()
        {
            query = new RoomQuery();
        }
        public void Delete(int id)
        {
            Command = new SqlCommand(query.Delete(), Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("RoomId", id);

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

        public void Insert(RoomModel room)
        {
            Command = new SqlCommand(query.Insert(), Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("RoomNo", room.RoomNo);
                Command.Parameters.AddWithValue("RoomName", room.RoomName);
                Command.Parameters.AddWithValue("CompanyId", room.CompanyId);
                Command.Parameters.AddWithValue("ModifiedDate", room.ModifiedDate);
                Command.Parameters.AddWithValue("IsDefault", room.IsDefault);
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

        public void Update(RoomModel room)
        {
            Command = new SqlCommand(query.Update(), Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("RoomId", room.RoomId);
                Command.Parameters.AddWithValue("RoomNo", room.RoomNo);
                Command.Parameters.AddWithValue("RoomName", room.RoomName);
                Command.Parameters.AddWithValue("CompanyId", room.CompanyId);
                Command.Parameters.AddWithValue("ModifiedDate", room.ModifiedDate);
                Command.Parameters.AddWithValue("IsDefault", room.IsDefault);
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

        public DataTable GetRoom(int id)
        {
            Command = new SqlCommand(query.Select(id), Connection);
            Command.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            try
            {
                Command.Parameters.AddWithValue("RoomId", id);

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
        public int RoomSessionStart(string RoomNo)
        {
            Command = new SqlCommand(query.RoomSessionStart(), Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("RoomNo", RoomNo);
            try
            {
                return Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public int RoomSessionEnd(string RoomNo)
        {
            Command = new SqlCommand(query.RoomSessionEnd(), Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("RoomNo", RoomNo);

            try
            {
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
    }
}
