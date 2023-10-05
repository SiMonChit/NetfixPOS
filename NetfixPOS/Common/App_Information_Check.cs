using NetfixPOS.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Common
{
    public class App_Information_Check
    {
        ShopController _shop;
        public App_Information_Check()
        {
            _shop = new ShopController();
        }

        public int Check_IsRegister()
        {
            return _shop.Check_IsRegister();
        }
    }
}
