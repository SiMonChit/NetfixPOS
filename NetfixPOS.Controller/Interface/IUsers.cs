using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Controller.Interface
{
    interface IUsers
    {
        void Insert(UsersModel users);
        void Update(UsersModel users);
        void Delete(int id);
    }
}
