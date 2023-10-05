using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.DataAccess.Interface
{
    interface IIncome
    {
        void Insert(IncomeModel income);
        void Update(IncomeModel income);
        void Delete(int id);
    }
}
