using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Controller.Interface
{
    interface IDepartment
    {
        void Insert(DepartmentModel department);
        void Update(DepartmentModel department);
        void Delete(int id);
    }
}
