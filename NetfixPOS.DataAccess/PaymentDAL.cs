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
    public class PaymentDAL : DataControllerBase, IPayment
    {
        public int Insert(PaymentModel payment, string SaleId)
        {
            string query = "Payment_Insert";
            Command = new SqlCommand(query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            try
            {
                Command.Parameters.AddWithValue("PaymentType", payment.PaymentType);
                Command.Parameters.AddWithValue("PaySlipDate", payment.PaySlipDate);
                Command.Parameters.AddWithValue("PaySlipNo", payment.PaySlipNo);
                Command.Parameters.AddWithValue("PaidAmount", payment.PaidAmount);
                Command.Parameters.AddWithValue("Remark", payment.Remark);
                Command.Parameters.AddWithValue("UserID", payment.UserID);
                Command.Parameters.AddWithValue("SaleId", SaleId);
                Connection.Open();

                //Room Session End
                //SaleDAL _sale = new SaleDAL();
                //string RoomNo = _sale.SelectHeaderRow(SaleId).RoomNo;
                //if (!string.IsNullOrEmpty(RoomNo))
                //{
                //    RoomDAL _room = new RoomDAL();
                //    _room.RoomSessionEnd(RoomNo);
                //}

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

        public void Update(PaymentModel payment)
        {
            throw new NotImplementedException();
        }
        public DataTable GetPaymentList(string SaleId)
        {
            Command = new SqlCommand("Payment_Select", Connection);
            Command.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            try
            {
                Command.Parameters.AddWithValue("SaleId", SaleId);

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
