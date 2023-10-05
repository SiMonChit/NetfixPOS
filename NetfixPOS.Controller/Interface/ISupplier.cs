using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Controller.Interface
{
    interface ISupplier
    {
        int Insert(SupplierModel supplier);
        int Update(SupplierModel supplier);
        int Delete(int id);
    }
}
