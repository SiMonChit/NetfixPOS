using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Controller.Interface
{
    interface ITable
    {
        void Insert(TableModel table);

        void Update(TableModel table);
        void Delete(int id);

    }
}
