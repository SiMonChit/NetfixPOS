using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.DataAccess.Interface
{
    interface ICurrency
    {
        void Insert(CurrencyModel currency);
        void Update(CurrencyModel currency);
        void Delete(int id);
    }
}
