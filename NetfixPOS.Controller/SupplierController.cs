using NetfixPOS.Controller.Interface;
using NetfixPOS.DataAccess;
using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Controller
{
    public class SupplierController: ISupplier
    {
        readonly SupplierDAL _supplier;
        readonly EventLogsController _eventLogs;
        public SupplierController()
        {
            _supplier = new SupplierDAL();
            _eventLogs = new EventLogsController();
        }
        private int isSuccess = 0;
        public int Delete(int id)
        {
            try
            {
                isSuccess = _supplier.Delete(id);
                _eventLogs.AddLog("Delete", DateTime.Now, "Supplier Form", "Delete SupplierId " + id.ToString(), "Delete Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Delete", DateTime.Now, "Supplier Form", "Delete Supplier", ex.Message);
            }
            return isSuccess;
        }

        public int Insert(SupplierModel supplier)
        {
            try
            {
                isSuccess = _supplier.Insert(supplier);
                _eventLogs.AddLog("Insert", DateTime.Now, "Supplier Form", "Insert " + supplier.SupplierName, "Insert Success");
                return isSuccess;
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Insert", DateTime.Now, "Supplier Form", "Insert Control", ex.Message);
                return 0;
            }
            return isSuccess;
        }

        public int Update(SupplierModel supplier)
        {
            try
            {
                isSuccess = _supplier.Update(supplier);
                _eventLogs.AddLog("Update", DateTime.Now, "Supplier Form", "Update " + supplier.SupplierName, "Update Success");
                return isSuccess;
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Update", DateTime.Now, "Supplier Form", "Update Control", ex.Message);
                return 0;
            }
        }

        public object GetSupplier(int id)
        {
            return _supplier.GetSupplier(id);
        }
    }
}
