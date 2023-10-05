using NetfixPOS.Controller.Interface;
using NetfixPOS.DataAccess;
using NetfixPOS.Models.DataSetFile;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Controller
{
    public class PurchaseController : IPurchase
    {
        PurchaseDAL _purchase;
        EventLogsController _eventLogs;
        int isSuccess = 0;
        public PurchaseController()
        {
            _purchase = new PurchaseDAL();
            _eventLogs = new EventLogsController();
        }
        public int Delete(int PurchaseId)
        {
            try
            {
                isSuccess = _purchase.Delete(PurchaseId);
                _eventLogs.AddLog("Delete", DateTime.Now, "Purchase Form", "Delete PurchaseId " + PurchaseId.ToString(), "Delete Success");
            }
            catch(Exception ex)
            {
                _eventLogs.AddLog("Delete", DateTime.Now, "Purchase Form", "Delete Purchase", ex.Message);
            }
            return isSuccess;
        }

        public int Insert(ds_Purchase.tbl_PurchaseRow purchaseRow)
        {
            try
            {
                isSuccess = _purchase.Insert(purchaseRow);
                _eventLogs.AddLog("Insert", DateTime.Now, "Purchase Form", "Insert " + purchaseRow.StockName, "Insert Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Insert", DateTime.Now, "Purchase Form", "Insert Purchase", ex.Message);
            }
            return isSuccess;
        }

        public int Update(ds_Purchase.tbl_PurchaseRow purchaseRow)
        {
            try
            {
                isSuccess = _purchase.Insert(purchaseRow);
                _eventLogs.AddLog("Update", DateTime.Now, "Purchase Form", "Update " + purchaseRow.StockName, "Update Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Update", DateTime.Now, "Purchase Form", "Update Purchase", ex.Message);
            }
            return isSuccess;
        }
        public DataTable GetPurchaseList(DateTime purdate)
        {
            return _purchase.GetPurchaseList(purdate);
        }
    }
}
