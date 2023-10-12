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
    public class DamageController : IDamage
    {
        DamageDAL _damage;
        EventLogsController _eventLogs;
        public DamageController()
        {
            _damage = new DamageDAL();
            _eventLogs = new EventLogsController();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetDamageList(DateTime dateTime)
        {
            return _damage.GetDamageList(dateTime);
        }
        public DataTable GetDamageList(DateTime fromDate, DateTime toDate)
        {
            return _damage.GetDamageList(fromDate, toDate);
        }
        public void Insert(DamageModel damage)
        {
            try
            {
                _damage.Insert(damage);
                _eventLogs.AddLog("Insert", DateTime.Now, "Damage Form", "Insert " + damage.TableOrRoom +" , "+damage.Dmg_Description, "Insert Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Insert", DateTime.Now, "Damage Form", "Insert Damage", ex.Message);
            }
        }

        public void Update(DamageModel damage)
        {
            try
            {
                _damage.Update(damage);
                _eventLogs.AddLog("Update", DateTime.Now, "Damage Form", "Update " + damage.TableOrRoom + " , " + damage.Dmg_Description, "Update Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Update", DateTime.Now, "Damage Form", "Update Damage", ex.Message);
            }
        }
    }
}
