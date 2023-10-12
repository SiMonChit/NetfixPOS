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
    public class EndOfDayController : IEndOfDay
    {
        readonly EndOfDayDAL _endofday;
        EventLogsController _eventLogs;
        public EndOfDayController()
        {
            _endofday = new EndOfDayDAL();
            _eventLogs = new EventLogsController();
        }
        public int Insert(EndOfDayModel emdOfDay)
        {
            int isSuccess = 0;
            try
            {
                isSuccess = _endofday.Insert(emdOfDay);
                _eventLogs.AddLog("Insert", DateTime.Now, "EndOfDay Form", "Insert " + emdOfDay.VoucherAmount.ToString() +" User : " + emdOfDay.UserID, " Insert Success");
                return isSuccess;
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Insert", DateTime.Now, "EndOfDay Form", "Insert EndOfDay", ex.Message);
                return 0;
            }
        }
        public DataTable GetListForEnd(int userid, DateTime saledate)
        {
            return _endofday.GetListForEnd(userid, saledate);
        }
        public DataTable GetListEndOfDay(int userid)
        {
            return _endofday.GetListEndOfDay(userid);
        }
        public DataTable GetSaleDetailForDayEnd(int userid, DateTime saledate)
        {
            return _endofday.GetSaleDetailForDayEnd(userid, saledate);
        }
        public bool CheckEndOfDay(DateTime nowdate)
        {
            DataTable dt = new DataTable();
            dt = _endofday.CheckEndOfDay(nowdate);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else return false;
        }
    }
}
