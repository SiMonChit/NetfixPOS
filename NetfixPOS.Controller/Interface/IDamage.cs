using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Controller.Interface
{
    interface IDamage
    {
        void Insert(DamageModel damage);
        void Update(DamageModel damage);
        void Delete(int id);
        DataTable GetDamageList(DateTime dateTime);
    }
}
