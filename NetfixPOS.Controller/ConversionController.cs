using NetfixPOS.DataAccess;
using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Controller
{
    public class ConversionController
    {
        private ConversionDAL _conversion;
        public ConversionController()
        {
            _conversion = new ConversionDAL();
        }

        public dsNewSetup.SelectConversionDataTable ConversionSelectByStockId(string key)
        {
            return _conversion.ConversionSelectByStockId(key);
        }
    }
}
