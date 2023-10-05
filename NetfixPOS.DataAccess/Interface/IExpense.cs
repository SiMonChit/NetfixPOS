using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.DataAccess.Interface
{
    interface IExpense
    {
        void Insert(ExpenseModel expense);
        void Update(ExpenseModel expense);
        void Delete(int id);
    }
}
