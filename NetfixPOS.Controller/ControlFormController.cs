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
    public class ControlFormController : IControlForm
    {
        readonly ControlFormDAL _controlform;
        readonly EventLogsController _eventLogs;
        public ControlFormController()
        {
            _controlform = new ControlFormDAL();
            _eventLogs = new EventLogsController();
        }
        private int isSuccess = 0;
        public int Delete(int id)
        {
            try
            {
                isSuccess = _controlform.Delete(id);
                _eventLogs.AddLog("Delete", DateTime.Now, "Control Form", "Delete ControlId " + id.ToString(), "Delete Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Delete", DateTime.Now, "Control Form", "Delete Control", ex.Message);
            }
            return isSuccess;
        }

        public DataTable GetControlForm(int id)
        {
            return _controlform.GetControlForms(id);
        }

        public int Insert(ControlFormModel controlForm)
        {
            try
            {
                isSuccess = _controlform.Insert(controlForm);
                _eventLogs.AddLog("Insert", DateTime.Now, "Control Form", "Insert " + controlForm.ControlForm, "Insert Success");
                return isSuccess;
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Insert", DateTime.Now, "Control Form", "Insert Control", ex.Message);
                return 0;
            }
        }

        public int Update(ControlFormModel controlForm)
        {
            try
            {
                isSuccess = _controlform.Update(controlForm);
                _eventLogs.AddLog("Insert", DateTime.Now, "Control Form", "Update " + controlForm.ControlForm, "Insert Success");
                return isSuccess;
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Insert", DateTime.Now, "Control Form", "Update Control", ex.Message);
                return 0;
            }
        }
    }
}
