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
    public class EmployeeController:IEmployee
    {
        private EmployeeDAL _employee;
        private EventLogsController _eventLogs;
        public EmployeeController()
        {
            _employee = new EmployeeDAL();
            _eventLogs = new EventLogsController();
        }

        public void Delete(int id)
        {
            try
            {
                _employee.Delete(id);
                _eventLogs.AddLog("Delete", DateTime.Now, "Employee Form", "Delete EmployeeId " + id.ToString(), "Delete Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Delete", DateTime.Now, "Employee Form", "Delete Employee", ex.Message);
            }
        }

        public void Insert(EmployeeModel employee)
        {
            try
            {
                _employee.Insert(employee);
                _eventLogs.AddLog("Insert", DateTime.Now, "Employee Form", "Insert " + employee.EmpName, "Insert Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Insert", DateTime.Now, "Employee Form", "Insert Employee", ex.Message);
            }
        }

        public void Update(EmployeeModel employee)
        {
            try
            {
                _employee.Update(employee);
                _eventLogs.AddLog("Update", DateTime.Now, "Employee Form", "Update Employee", "Update Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Update", DateTime.Now, "Employee Form", "Update Employee", ex.Message);
            }
        }

        public DataTable GetEmpList(int deptId)
        {
            return _employee.GetEmpList(deptId);
        }
    }
}
