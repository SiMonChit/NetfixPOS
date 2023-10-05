using NetfixPOS.Models.DataSetFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Controller.Interface
{
    interface IPurchase
    {
        int Insert(ds_Purchase.tbl_PurchaseRow  purchaseRow);
        int Update(ds_Purchase.tbl_PurchaseRow purchaseRow);
        int Delete(int PurchaseId);
    }
}
