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
    public class UserPermissionController: IPermission
    {
        private UserPermissionDAL _permisson;
        private EventLogsController _eventLogs;
        public UserPermissionController()
        {
            _permisson = new UserPermissionDAL();
            _eventLogs = new EventLogsController();
        }
        public DataTable GetUserPermissionList(int id)
        {
            return _permisson.GetUserPermissionList(id);
        }
        public ds_Permission.UserPermissionDataTable GetPermission(int userid)
        {
            return _permisson.GetPermission(userid);
        }
        public void Insert(ds_Permission.UserPermissionRow permissionRow)
        {
            try
            {
                _permisson.Insert(permissionRow);
                _eventLogs.AddLog("Insert", DateTime.Now, "Permission Form", "Insert " + permissionRow.ControlId + " , " + "IsSave "+ permissionRow.IsSave.ToString()+" "+"IsUpdate "+permissionRow.IsUpdate.ToString(), "Insert Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Insert", DateTime.Now, "Permission Form", "Insert Permission", ex.Message);
            }
            
        }

        public int Update(ds_Permission.UserPermissionRow permissionRow)
        {
            int isSuccess = 0;
            isSuccess = _permisson.Update(permissionRow);
            if (isSuccess == 1)
            {
                try
                {
                    _eventLogs.AddLog("Update", DateTime.Now, "Permission Form", "Update " + permissionRow.ControlId + " , " + "IsSave " + permissionRow.IsSave.ToString() + " " + "IsUpdate " + permissionRow.IsUpdate.ToString(), "Update Success");
                }
                catch (Exception ex)
                {
                    _eventLogs.AddLog("Update", DateTime.Now, "Permission Form", "Update Permission", ex.Message);
                }
            }
            return isSuccess;
            
        }
    }
}
