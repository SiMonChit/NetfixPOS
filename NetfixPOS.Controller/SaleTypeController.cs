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
    public class SaleTypeController : ISaleType
    {
        SaleTypeDAL _saletype;
        EventLogsController _eventLogs;

        public SaleTypeController()
        {
            _saletype = new SaleTypeDAL();
            _eventLogs = new EventLogsController();
        }
        public void Delete(int id)
        {
            try
            {
                _saletype.Delete(id);
                _eventLogs.AddLog("Delete", DateTime.Now, "SaleType Form", "Delete SaleTypeId " + id.ToString(), "Delete Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Delete", DateTime.Now, "SaleType Form", "Delete SaleType", ex.Message);
            }
        }

        public void Insert(SaleTypeModel saleType)
        {
            try
            {
                _saletype.Insert(saleType);
                _eventLogs.AddLog("Insert", DateTime.Now, "SaleType Form", "Insert " + saleType.SaleTypeName, "Insert Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Insert", DateTime.Now, "SaleType Form", "Insert SaleType", ex.Message);
            }
        }

        public void Update(SaleTypeModel saleType)
        {
            try
            {
                _saletype.Update(saleType);
                _eventLogs.AddLog("Update", DateTime.Now, "SaleType Form", "Update SaleType", "Update Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Update", DateTime.Now, "SaleType Form", "Update SaleType", ex.Message);
            }
        }
        public DataTable GetSaleType()
        {
            return _saletype.GetSaleType();
        }
    }
}
