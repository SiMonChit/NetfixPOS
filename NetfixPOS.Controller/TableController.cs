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
    public class TableController : ITable
    {
        private TableDAL _table;
        private EventLogsController _eventLogs;
        public TableController()
        {
            _table = new TableDAL();
            _eventLogs = new EventLogsController();
        }

        public void Delete(int id)
        {
            try
            {
                _table.Delete(id);
                _eventLogs.AddLog("Delete", DateTime.Now, "Table Form", "Delete TableId " + id.ToString(), "Delete Success");
            }
            catch(Exception ex)
            {
                _eventLogs.AddLog("Delete", DateTime.Now, "Table Form", "Delete Category", ex.Message);
            }
        }

        public void Insert(TableModel table)
        {
            try
            {
                _table.Insert(table);
                _eventLogs.AddLog("Insert", DateTime.Now, "Table Form", "Insert " + table.TableNo + " " + table.TableName, "Insert Success");
            }
            catch(Exception ex)
            {
                _eventLogs.AddLog("Insert", DateTime.Now, "Table Form", "Insert Table", ex.Message);
            }
            
        }

        public void Update(TableModel table)
        {
            try
            {
                _table.Update(table);
                _eventLogs.AddLog("Update", DateTime.Now, "Table Form", "Update Table", "Update Success");
            }
            catch(Exception ex)
            {
                _eventLogs.AddLog("Update", DateTime.Now, "Table Form", "Update Table", ex.Message);
            }
            
        }
        public DataTable GetTable(int id)
        {
            return _table.GetTable(id);
        }
    }
}
