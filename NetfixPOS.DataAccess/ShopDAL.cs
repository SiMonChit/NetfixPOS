using NetfixPOS.DataAccess.Interface;
using NetfixPOS.Models;
using NetfixPOS.Models.DataSetFile;
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
    public class ShopDAL : DataControllerBase, IShop
    {
        ShopQuery query;
        public ShopDAL()
        {
            query = new ShopQuery();
        }
        public int Insert(ShopModel shop)
        {
            Command = new SqlCommand("INSERT ShopInfo VALUES(@ShopLogo, @ShopName,  @PhoneNo, @Email, @CurrentAddress, 1)", Connection);
            Command.CommandType = CommandType.Text;

            Command.Parameters.AddWithValue("ShopName", shop.ShopName);
            Command.Parameters.AddWithValue("ShopLogo", shop.ShopLogo);
            Command.Parameters.AddWithValue("PhoneNo", shop.PhoneNo);
            Command.Parameters.AddWithValue("Email", shop.Email);
            Command.Parameters.AddWithValue("CurrentAddress", shop.CurrentAddress);

            try
            {
                if (Connection.State == ConnectionState.Closed) Connection.Open();

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

        public int Update(ShopModel shop)
        {
            throw new NotImplementedException();
        }
        public ds_ShopInfo.ShopInfoRow Select()
        {
            ds_ShopInfo.ShopInfoDataTable dt = new ds_ShopInfo.ShopInfoDataTable();

            try
            {
                Command = new SqlCommand("SELECT * FROM ShopInfo WHERE IsActive = 1", Connection);
                Command.CommandType = CommandType.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(Command);
                adapter.Fill(dt);
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

            return dt[0];
        }

        public ds_ShopInfo.ShopInfoRow GetShopName()
        {
            ds_ShopInfo.ShopInfoDataTable dt = new ds_ShopInfo.ShopInfoDataTable();

            try
            {
                Command = new SqlCommand(query.GetShopName(), Connection);
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("ShopId", 1);

                SqlDataAdapter adapter = new SqlDataAdapter(Command);
                adapter.Fill(dt);
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

            return dt[0];
        }

        public int Check_IsRegister()
        {
            DataTable dt = new DataTable();

            try
            {
                Command = new SqlCommand("SELECT * FROM ShopInfo WHERE IsActive = 1", Connection);
                Command.CommandType = CommandType.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(Command);
                adapter.Fill(dt);
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

            return dt.Rows.Count;
        }


    }
}
