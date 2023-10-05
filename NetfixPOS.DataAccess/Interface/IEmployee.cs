using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.DataAccess.Interface
{
    interface IEmployee
    {
        void Insert(EmployeeModel employee);
        void Update(EmployeeModel employee);
        void Delete(int id);
    }
}
