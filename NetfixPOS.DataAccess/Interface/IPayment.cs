using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.DataAccess.Interface
{
    interface IPayment
    {
        int Insert(PaymentModel payment, string SaleId);
        void Update(PaymentModel payment);
        DataTable GetPaymentList(string SaleId);

    }
}
