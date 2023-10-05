using NetfixPOS.Controller.Interface;
using NetfixPOS.DataAccess;
using NetfixPOS.Models;
using NetfixPOS.Models.DataSetFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Controller
{
    public class ShopController : IShop
    {
        ShopDAL _shop;
        EventLogsController _eventLogs;
        public ShopController()
        {
            _shop = new ShopDAL();
            _eventLogs = new EventLogsController();
        }
        public int Insert(ShopModel shop)
        {
            return _shop.Insert(shop);
        }

        public int Update(ShopModel shop)
        {
            return _shop.Update(shop);
        }
        public ds_ShopInfo.ShopInfoRow Select()
        {
            return _shop.Select();
        }
        public int Check_IsRegister()
        {
            return _shop.Check_IsRegister();
        }
    }
}
