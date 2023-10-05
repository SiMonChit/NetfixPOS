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
    public class SaleDAL : DataControllerBase, ISale
    {
        public void HeaderDelete(string id)
        {
            throw new NotImplementedException();
        }

        public void HeaderInsert(dsSaleSetup.SaleHeaderRow headerRow, dsSaleSetup.SaleDetailDataTable detail_dt)
        {
            if (Connection.State == ConnectionState.Closed) Connection.Open();

            Transaction = Connection.BeginTransaction();

            Command = new SqlCommand("SaleHeader_Insert", Connection, Transaction);
            Command.CommandType = CommandType.StoredProcedure;

            Command.Parameters.AddWithValue("TableNo", headerRow.TableNo);
            Command.Parameters.AddWithValue("RoomNo", headerRow.RoomNo);
            Command.Parameters.AddWithValue("CustomerId", headerRow.CustomerId);
            Command.Parameters.AddWithValue("UserID", headerRow.UserID);
            Command.Parameters.AddWithValue("SaleTypeId", headerRow.SaleTypeId);
            Command.Parameters.AddWithValue("InvNo", headerRow.InvNo);
            Command.Parameters.AddWithValue("InvDate", headerRow.InvDate);
            Command.Parameters.AddWithValue("Remark", headerRow.Remark);
            Command.Parameters.AddWithValue("NetAmount", headerRow.NetAmount);
            Command.Parameters.AddWithValue("TotalAmount", headerRow.TotalAmount);
            Command.Parameters.AddWithValue("DiscountAmount", headerRow.DiscountAmount);
            Command.Parameters.AddWithValue("AdvanceAmount", headerRow.AdvanceAmount);
            Command.Parameters.AddWithValue("BalanceAmount", headerRow.BalanceAmount);
            Command.Parameters.AddWithValue("DueAmount", headerRow.DueAmount);
            Command.Parameters.AddWithValue("DeliveryFee", headerRow.DeliveryFee);
            Command.Parameters.AddWithValue("C_tax", headerRow.C_tax);
            Command.Parameters.AddWithValue("IsFOC", headerRow.IsFOC);
            Command.Parameters.AddWithValue("InvoiceStatus", headerRow.InvoiceStatus);
            Command.Parameters.AddWithValue("WaiterName", headerRow.WaiterName);
            Command.Parameters.AddWithValue("PrintDate", headerRow.PrintDate);

            try
            {
                string key = Command.ExecuteScalar().ToString();

                if (detail_dt.Rows.Count > 0)
                {
                    //Insert Sale Items
                    ItemInsert(key, detail_dt, Connection, Transaction);
                }

            }
            catch (Exception ex)
            {
                Transaction.Rollback();
                throw ex;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Transaction.Commit();
                    Connection.Close();
                }
            }
        }

        public void HeaderUpdate(dsSaleSetup.SaleHeaderRow headerRow)
        {
            throw new NotImplementedException();
        }



        public DataTable Table_ForSale()
        {
            Command = new SqlCommand("Table_SelectForInvoice", Connection);
            Command.CommandType = CommandType.StoredProcedure;

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

        public DataTable Room_ForSale()
        {
            Command = new SqlCommand("Room_SelectForInvoice", Connection);
            Command.CommandType = CommandType.StoredProcedure;

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

        public void HeaderUpdate(dsSaleSetup.SaleHeaderRow headerRow, dsSaleSetup.SaleDetailDataTable detail_dt)
        {
            throw new NotImplementedException();
        }

        public void ItemInsert(string headerKey, dsSaleSetup.SaleDetailDataTable detail_dt, SqlConnection connection, SqlTransaction transaction)
        {
            foreach (dsSaleSetup.SaleDetailRow detail_row in detail_dt)
            {
                detail_row.SaleId = headerKey;
                Command = new SqlCommand("SaleDetail_Insert", Connection, transaction);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("SaleId", detail_row.SaleId);
                Command.Parameters.AddWithValue("StockId", detail_row.StockId);
                Command.Parameters.AddWithValue("CategoryID", detail_row.CategoryID);
                Command.Parameters.AddWithValue("ConvensionId", detail_row.ConvensionId);
                Command.Parameters.AddWithValue("Serial", detail_row.Serial);
                Command.Parameters.AddWithValue("Qty", detail_row.Qty);
                Command.Parameters.AddWithValue("SalePrice", detail_row.SalePrice);
                Command.Parameters.AddWithValue("Discount", detail_row.Discount);
                Command.Parameters.AddWithValue("Amount", detail_row.Amount);
                Command.Parameters.AddWithValue("IsFOC", detail_row.IsFOC);

                try
                {
                    //Connection.Open();
                    Command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                //finally
                //{
                //    if (Connection.State == ConnectionState.Open)
                //        Connection.Close();
                //}
            }
        }

        public void ItemUpdate(string headerKey, dsSaleSetup.SaleDetailDataTable detail_dt, SqlConnection connection, SqlTransaction transaction)
        {
            foreach (dsSaleSetup.SaleDetailRow detail_row in detail_dt)
            {
                detail_row.SaleId = headerKey;
                Command = new SqlCommand("SaleDetail_Update", Connection);
                Command.CommandType = CommandType.StoredProcedure;

                Command.Parameters.AddWithValue("SaleDetailId", detail_row.SaleDetailId);
                Command.Parameters.AddWithValue("SaleId", detail_row.SaleId);
                Command.Parameters.AddWithValue("StockId", detail_row.StockId);
                Command.Parameters.AddWithValue("CategoryID", detail_row.CategoryID);
                Command.Parameters.AddWithValue("ConvensionId", detail_row.ConvensionId);
                Command.Parameters.AddWithValue("Serial", detail_row.Serial);
                Command.Parameters.AddWithValue("Qty", detail_row.Qty);
                Command.Parameters.AddWithValue("SalePrice", detail_row.SalePrice);
                Command.Parameters.AddWithValue("Discount", detail_row.Discount);
                Command.Parameters.AddWithValue("Amount", detail_row.Amount);
                Command.Parameters.AddWithValue("IsFOC", detail_row.IsFOC);

                try
                {
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



        #region Select Header

        public dsSaleSetup.SaleHeaderSlipRow SaleHeaderSlipSelectById(string id)
        {
            dsSaleSetup.SaleHeaderSlipDataTable dt = new dsSaleSetup.SaleHeaderSlipDataTable();


            try
            {
                Command = new SqlCommand("SaleHeader_SelectBySaleId", Connection);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@SaleId", id);

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


        public dsSaleSetup.SaleHeaderRow SaleHeaderSelectById(string id)
        {
            dsSaleSetup.SaleHeaderDataTable dt = new dsSaleSetup.SaleHeaderDataTable();

            try
            {
                Command = new SqlCommand("SELECT * FROM SaleHeader WHERE SaleId = @SaleId", Connection);
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@SaleId", id);

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


        public dsSaleSetup.SaleDetailDataTable SaleDetailSelectByHeaderId(string headerId)
        {
            Command = new SqlCommand("SaleDetail_SelectBySaleId", Connection);
            Command.CommandType = CommandType.StoredProcedure;
            dsSaleSetup.SaleDetailDataTable dt = new dsSaleSetup.SaleDetailDataTable();
            try
            {
                Command.Parameters.AddWithValue("SaleId", headerId);

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

        public DataTable SaleHeaderSelectByDate(DateTime fromDate, DateTime toDate)
        {
            Command = new SqlCommand("SaleHeader_SelectByDate", Connection);
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

        public ds_SaleSlip.tbl_SaleSlipDataTable SaleDetailsSlip_SelectById(string saleid)
        {
            ds_SaleSlip.tbl_SaleSlipDataTable dt = new ds_SaleSlip.tbl_SaleSlipDataTable();
            try
            {
                Command = new SqlCommand("SaleDetailsSelectById", Connection);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("SaleId", saleid);

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

        #endregion
        #region JoinTable

        public void JoinTable(string id, string name, string otherId, string otherName)
        {

            try
            {
                Command = new SqlCommand("JoinSelectedTableData", Connection);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("id", id);
                Command.Parameters.AddWithValue("name", name);
                Command.Parameters.AddWithValue("otherId", otherId);
                Command.Parameters.AddWithValue("otherName", otherName);
                Connection.Open();
                Command.ExecuteScalar();
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

        #endregion

        #region Select Item
        public DataTable SaleItemSelectByDate(DateTime fromDate, DateTime toDate)
        {
            Command = new SqlCommand("SaleDetail_SelectByDate", Connection);
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

        #endregion
    }
}
