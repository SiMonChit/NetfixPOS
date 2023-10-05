using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Controller.Interface
{
    interface ISale
    {
        void Insert(dsSaleSetup.SaleHeaderRow headerRow, dsSaleSetup.SaleDetailDataTable detail_dt);
        void Update(dsSaleSetup.SaleHeaderRow headerRow, dsSaleSetup.SaleDetailDataTable detail_dt);
    }
}
