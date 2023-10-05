using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Controller.Interface
{
    interface IShop
    {
        int Insert(ShopModel shop);
        int Update(ShopModel shop);
    }
}
