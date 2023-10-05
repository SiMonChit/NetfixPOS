using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Controller.Interface
{
    interface IAutoGenerate
    {
        void Insert(AutoGenerateModel generate);
        void Update(AutoGenerateModel generate);
        void Delete(int id);
    }
}
