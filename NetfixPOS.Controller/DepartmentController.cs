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
    public class DepartmentController : IDepartment
    {
        private DepartmentDAL _department;
        private EventLogsController _eventLogs;
        public DepartmentController()
        {
            _department = new DepartmentDAL();
            _eventLogs = new EventLogsController();
        }
        public void Delete(int id)
        {
            try
            {
                _department.Delete(id);
                _eventLogs.AddLog("Delete", DateTime.Now, "Department Form", "Delete DepartmentId " + id.ToString(), "Delete Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Delete", DateTime.Now, "Department Form", "Delete Currency", ex.Message);
            }
        }

        public void Insert(DepartmentModel department)
        {
            try
            {
                _department.Insert(department);
                _eventLogs.AddLog("Insert", DateTime.Now, "Department Form", "Insert " + department.DepartmentName, "Insert Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Insert", DateTime.Now, "Department Form", "Insert Department", ex.Message);
            }
        }

        public void Update(DepartmentModel department)
        {
            try
            {
                _department.Update(department);
                _eventLogs.AddLog("Update", DateTime.Now, "Department Form", "Update Department", "Update Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Update", DateTime.Now, "Department Form", "Update Department", ex.Message);
            }
        }
        public DataTable GetDepartment(int id)
        {
            return _department.GetDepartment(id);
        }
    }
}
