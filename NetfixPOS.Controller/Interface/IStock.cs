using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Controller.Interface
{
    interface IStock
    {
        void Insert(StockModel stock, dsNewSetup.ConversionDataTable convDT);
        void Update(StockModel stock, dsNewSetup.ConversionDataTable convDT);
        void Delete(string id);
    }
}
