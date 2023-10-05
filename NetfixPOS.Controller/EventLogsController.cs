using NetfixPOS.Controller.Common;
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
    public class EventLogsController
    {
        private EventLogsDAL eventLogs;
        public EventLogsController()
        {
            eventLogs = new EventLogsDAL();
        }
        public void AddLog(string LogType, DateTime LogDatetime, string Source, string LogMessage, string ErrMessage)
        {
            EventLogsModel eventLog = new EventLogsModel();
            eventLog.LogType = LogType;
            eventLog.LogDateTime = LogDatetime;
            eventLog.Source = Source;
            eventLog.LogMessage = LogMessage;
            eventLog.ErrMessage = ErrMessage;
            eventLog.LocalIP = GlobalFunction.GetComputerName();

            eventLogs.AddLog(eventLog);
        }
        public DataTable ReadLog(DateTime fromDate, DateTime toDate)
        {
            return eventLogs.ReadLog(fromDate, toDate);
        }
    }
}
