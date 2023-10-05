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
    public class CurrencyController : ICurrency
    {
        private CurrencyDAL _currency;
        private EventLogsController _eventLogs;
        public CurrencyController()
        {
            _currency = new CurrencyDAL();
            _eventLogs = new EventLogsController();
        }
        public void Delete(int id)
        {
            try
            {
                _currency.Delete(id);
                _eventLogs.AddLog("Delete", DateTime.Now, "Currency Form", "Delete CurrencyId " + id.ToString(), "Delete Success");
            }
            catch(Exception ex)
            {
                _eventLogs.AddLog("Delete", DateTime.Now, "Currency Form", "Delete Currency", ex.Message);
            }
        }

        public void Insert(CurrencyModel currency)
        {
            try
            {
                _currency.Insert(currency);
                _eventLogs.AddLog("Insert", DateTime.Now, "Currency Form", "Insert " + currency.Currency, "Insert Success");
            }
            catch(Exception ex)
            {
                _eventLogs.AddLog("Insert", DateTime.Now, "Currency Form", "Insert Currency", ex.Message);
            }
        }

        public void Update(CurrencyModel currency)
        {
            try
            {
                _currency.Update(currency);
                _eventLogs.AddLog("Update", DateTime.Now, "Currency Form", "Update Currency", "Update Success");
            }
            catch(Exception ex)
            {
                _eventLogs.AddLog("Update", DateTime.Now, "Currency Form", "Update Currency", ex.Message);
            }
        }

        public DataTable GetCurrency(int id)
        {
            return _currency.GetCurrency(id);
        }
        public DataRow GetDefaultCurrency()
        {
            return _currency.GetDefaultCurrency();
        }
    }
}
