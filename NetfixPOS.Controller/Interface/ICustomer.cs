using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Controller.Interface
{
    interface ICustomer
    {
        void Insert(CustomerModel customer);
        void Update(CustomerModel customer);
        void Delete(int id);
    }
}
