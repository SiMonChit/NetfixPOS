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
    public class IncomeController : IIncome
    {
        private IncomeDAL _income;
        private EventLogsController _eventLogs;
        public IncomeController()
        {
            _income = new IncomeDAL();
            _eventLogs = new EventLogsController();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(IncomeModel income)
        {
            try
            {
                _income.Insert(income);
                _eventLogs.AddLog("Insert", DateTime.Now, "Income Form", "Insert " + income.In_Description + " , " + income.In_Amount, "Insert Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Insert", DateTime.Now, "Income Form", "Insert Income", ex.Message);
            }
        }

        public void Update(IncomeModel income)
        {
            try
            {
                _income.Update(income);
                _eventLogs.AddLog("Update", DateTime.Now, "Income Form", "Update " + income.In_Description + " , " + income.In_Amount, "Update Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Update", DateTime.Now, "Income Form", "Update Income", ex.Message);
            }
        }

        public DataTable GetIncome_List(DateTime month)
        {
            return _income.GetIncome_List(month);
        }
        public DataTable GetIncome_ListByDate(DateTime fromDate, DateTime toDate)
        {
            return _income.GetIncome_ListByDate(fromDate, toDate);
        }
    }
}
