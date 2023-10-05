using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Controller.Interface
{
    interface IControlForm
    {
        int Insert(ControlFormModel controlForm);
        int Update(ControlFormModel controlForm);
        int Delete(int id);
    }
}
