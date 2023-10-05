using NetfixPOS.Controller.Interface;
using NetfixPOS.DataAccess;
using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Controller
{
    public class PaymentController : IPayment
    {
        private PaymentDAL _payment;
        private EventLogsController _eventLogs;
        public PaymentController()
        {
            _payment = new PaymentDAL();
            _eventLogs = new EventLogsController();
        }
        public DataTable GetPaymentList(string SaleId)
        {
            return _payment.GetPaymentList(SaleId);
        }

        public int Insert(PaymentModel payment)
        {
            int isSuccess = 0;
            try
            {
                isSuccess= _payment.Insert(payment);
                _eventLogs.AddLog("Insert", DateTime.Now, "Payment Form", "Insert " + payment.PaySlipNo + " " + payment.PaidAmount.ToString() +" "+"User :"+payment.UserID, "Insert Success");
                return isSuccess;
            }
            catch(Exception ex)
            {
                _eventLogs.AddLog("Insert", DateTime.Now, "Payment Form", "Insert Payment", ex.Message);
                return 0;
            }
        }

        public void Update(PaymentModel payment)
        {
            throw new NotImplementedException();
        }
    }
}
