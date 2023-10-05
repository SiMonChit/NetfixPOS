using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Controller.Interface
{
    interface IRoom
    {
        void Insert(RoomModel room);
        void Update(RoomModel room);
        void Delete(int id);
    }
}
