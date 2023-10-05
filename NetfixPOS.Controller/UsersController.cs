using NetfixPOS.Controller.Interface;
using NetfixPOS.DataAccess;
using NetfixPOS.Models;
using NetfixPOS.Models.DataSetFile;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Controller
{
    public class UsersController : IUsers
    {
        private UsersDAL _users;
        private EventLogsController _eventLogs;
        public UsersController()
        {
            _users = new UsersDAL();
            _eventLogs = new EventLogsController();
        }
        public void Delete(int id)
        {
            try
            {
                _users.Delete(id);
                _eventLogs.AddLog("Delete", DateTime.Now, "Users Form", "Delete UsersId " + id.ToString(), "Delete Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Delete", DateTime.Now, "Users Form", "Delete Users", ex.Message);
            }
        }

        public void Insert(UsersModel users)
        {
            try
            {
                _users.Insert(users);
                _eventLogs.AddLog("Insert", DateTime.Now, "Users Form", "Insert " + users.UserName, "Insert Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Insert", DateTime.Now, "Users Form", "Insert Currency", ex.Message);
            }
        }

        public void Update(UsersModel users)
        {
            try
            {
                _users.Update(users);
                _eventLogs.AddLog("Update", DateTime.Now, "Users Form", "Update Users", "Update Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Update", DateTime.Now, "Users Form", "Update Users", ex.Message);
            }
        }

        public DataTable GetUsers(int id)
        {
            return _users.GetUsers(id);
        }

        public ds_Users.UsersRow UsersLogin(string UserName, string Password)
        {
            return _users.UsersLogin(UserName, Password);
        }
        public void UsersLogout(int UserId)
        {
            _users.UsersLogout(UserId);
        }
    }
}
