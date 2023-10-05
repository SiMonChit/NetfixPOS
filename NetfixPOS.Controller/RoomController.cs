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
    public class RoomController : IRoom
    {
        private RoomDAL _room;
        private EventLogsController _eventLogs;
        public RoomController()
        {
            _room = new RoomDAL();
            _eventLogs = new EventLogsController();
        }
        public void Delete(int id)
        {
            try
            {
                _room.Delete(id);
                _eventLogs.AddLog("Delete", DateTime.Now, "Room Form", "Delete RoomId " + id.ToString(), "Delete Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Delete", DateTime.Now, "Room Form", "Delete Room", ex.Message);
            }
        }

        public void Insert(RoomModel room)
        {
            try
            {
                _room.Insert(room);
                _eventLogs.AddLog("Insert", DateTime.Now, "Room Form", "Insert " + room.RoomNo + " " + room.RoomName, "Insert Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Insert", DateTime.Now, "Room Form", "Insert Room", ex.Message);
            }

        }

        public void Update(RoomModel room)
        {
            try
            {
                _room.Update(room);
                _eventLogs.AddLog("Update", DateTime.Now, "Room Form", "Update Room", "Update Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Update", DateTime.Now, "Room Form", "Update Room", ex.Message);
            }

        }
        public DataTable GetRoom(int id)
        {
            return _room.GetRoom(id);
        }
    }
}
