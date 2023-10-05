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
    public class UnitController : IUnit
    {
        private UnitDAL _unit;
        private EventLogsController _eventLogs;
        public UnitController()
        {
            _unit = new UnitDAL();
            _eventLogs = new EventLogsController();
        }

        public void Delete(int id)
        {
            try
            {
                _unit.Delete(id);
                _eventLogs.AddLog("Delete", DateTime.Now, "Unit Form", "Delete UnitId " + id.ToString(), "Delete Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Delete", DateTime.Now, "Unit Form", "Delete UnitId", ex.Message);
            }

        }

        public DataTable GetUint()
        {
            return _unit.GetUint();
        }

        public void Insert(UnitModel unit)
        {
            try
            {
                _unit.Insert(unit);
                _eventLogs.AddLog("Insert", DateTime.Now, "Unit Form", "Insert " + unit.UnitName, "Insert Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Insert", DateTime.Now, "Unit Form", "Insert Unit", ex.Message);
            }
        }

        public void Update(UnitModel unit)
        {
            try
            {
                _unit.Update(unit);
                _eventLogs.AddLog("Update", DateTime.Now, "Unit Form", "Update " + unit.UnitName, "Update Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Update", DateTime.Now, "Unit Form", "Update Unit", ex.Message);
            }
        }
    }
}
