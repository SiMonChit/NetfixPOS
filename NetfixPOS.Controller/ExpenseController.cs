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
    public class ExpenseController : IExpense
    {

        private ExpenseDAL _expense;
        private EventLogsController _eventLogs;
        public ExpenseController()
        {
            _expense = new ExpenseDAL();
            _eventLogs = new EventLogsController();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetExpense_ListByDate(DateTime fromDate, DateTime toDate)
        {
            return _expense.GetExpense_ListByDate(fromDate, toDate);
        }

        public void Insert(ExpenseModel expense)
        {
            try
            {
                _expense.Insert(expense);
                _eventLogs.AddLog("Insert", DateTime.Now, "Expense Form", "Insert " + expense.Ex_Description + " , " + expense.Ex_Amount, "Insert Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Insert", DateTime.Now, "Expense Form", "Insert Expense", ex.Message);
            }
        }

        public void Update(ExpenseModel expense)
        {
            try
            {
                _expense.Update(expense);
                _eventLogs.AddLog("Update", DateTime.Now, "Expense Form", "Update " + expense.Ex_Description + " , " + expense.Ex_Description, "Update Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Update", DateTime.Now, "Expense Form", "Update Expense", ex.Message);
            }
        }

        public DataTable GetExpense_List(DateTime month)
        {
            return _expense.GetExpense_List(month);
        }
    }
}
