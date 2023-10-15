﻿using NetfixPOS.DataAccess.Interface;
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
    public class AutoGenerateDAL:DataControllerBase, IAutoGenerate
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(AutoGenerateModel generate)
        {

            Command = new SqlCommand("INSERT AutoGenerate VALUES(@GenerateDate, @GenerateNo, @LastValue, @GenerateType)", Connection);
            Command.CommandType = CommandType.Text;


            Command.Parameters.AddWithValue("GenerateNo", generate.GenerateNo);
            Command.Parameters.AddWithValue("GenerateDate", generate.GenerateDate);
            Command.Parameters.AddWithValue("LastValue", generate.LastValue);
            Command.Parameters.AddWithValue("GenerateType", generate.GenerateType);
            try
            {
                if (Connection.State == ConnectionState.Closed) Connection.Open();

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

        public void Update(AutoGenerateModel generate)
        {
            string sqlCmd = "UPDATE AutoGenerate SET GenerateDate = @GenerateDate, GenerateNo = @GenerateNo, LastValue = @LastValue, GenerateType = @GenerateType" +
                "WHERE GenerateID = @GenerateID";
            Command = new SqlCommand(sqlCmd, Connection);
            Command.CommandType = CommandType.Text;

            Command.Parameters.AddWithValue("GenerateID", generate.GenerateID);
            Command.Parameters.AddWithValue("GenerateNo", generate.GenerateNo);
            Command.Parameters.AddWithValue("GenerateDate", generate.GenerateDate);
            Command.Parameters.AddWithValue("LastValue", generate.LastValue);
            Command.Parameters.AddWithValue("GenerateType", generate.GenerateType);
            try
            {
                if (Connection.State == ConnectionState.Closed) Connection.Open();

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
        public string GetGenerateNo(string GenerateType)
        {
            if (Connection.State == ConnectionState.Closed) Connection.Open();

            SqlTransaction transaction = Connection.BeginTransaction();

            Command = new SqlCommand("FakeAutoCodeGenerator", Connection, transaction);
            Command.CommandType = CommandType.StoredProcedure;


            Command.Parameters.AddWithValue("GenerateType", GenerateType);
            string key = Command.ExecuteScalar().ToString();
            return key;
        }
        public DataTable GetGenerateData()
        {
            Command = new SqlCommand("SELECT * FROM AutoGenerate ORDER BY GenerateID", Connection);
            Command.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            try
            {
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

        public dsNewSetup.tbl_GE_AppInfoRow GetAppInfo(int ShopId)
        {
            dsNewSetup.tbl_GE_AppInfoDataTable dt = new dsNewSetup.tbl_GE_AppInfoDataTable();

            try
            {
                Command = new SqlCommand("SELECT * FROM tbl_GE_AppInfo WHERE IsActive = 1", Connection);
                Command.CommandType = CommandType.Text;

                if (Connection.State == ConnectionState.Closed) Connection.Open();

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
    
        public void AppInfo_Update(GeneralModel general)
        {
            AppInfoQuery query = new AppInfoQuery();

            Command = new SqlCommand(query.Update(), Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("General_Id", general.General_Id);
            Command.Parameters.AddWithValue("SaleDate", general.SaleDate);
            Command.Parameters.AddWithValue("ServiceTax", general.ServiceTax);
            Command.Parameters.AddWithValue("ServiceCharges", general.ServiceCharges);
            Command.Parameters.AddWithValue("InvDiscount", general.InvDiscount);
            try
            {
                if (Connection.State == ConnectionState.Closed) Connection.Open();

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

        public void AppInfo_Insert(GeneralModel general)
        {
            AppInfoQuery query = new AppInfoQuery();
            
            Command = new SqlCommand(query.Insert(), Connection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("ActivateKey", general.ActivateKey);
            Command.Parameters.AddWithValue("ShopId", general.ShopId);
            Command.Parameters.AddWithValue("SaleDate", general.SaleDate);
            Command.Parameters.AddWithValue("ServiceTax", general.ServiceTax);
            Command.Parameters.AddWithValue("ServiceCharges", general.ServiceCharges);
            Command.Parameters.AddWithValue("InvDiscount", general.InvDiscount);
            try
            {
                if (Connection.State == ConnectionState.Closed) Connection.Open();

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

        public dsNewSetup.tbl_GE_AppInfoDataTable GetAppInfo()
        {
            dsNewSetup.tbl_GE_AppInfoDataTable dt = new dsNewSetup.tbl_GE_AppInfoDataTable();

            try
            {
                Command = new SqlCommand("SELECT * FROM tbl_GE_AppInfo WHERE IsActive = 1", Connection);
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

            return dt;
        }
    }
}
