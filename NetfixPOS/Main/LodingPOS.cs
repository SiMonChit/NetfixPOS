using NetfixPOS.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Main
{
    public class LodingPOS
    {
        public LodingPOS()
        {
            _shop = new ShopController();
        }
        ShopController _shop;
    }
}
