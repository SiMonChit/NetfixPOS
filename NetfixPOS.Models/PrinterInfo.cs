using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Models
{
    public class PrinterInfo
    {
        public string DeviceID { get; }
        public string DisplayName { get; }

        public PrinterInfo(string deviceID, string displayName)
        {
            DeviceID = deviceID;
            DisplayName = displayName;
        }
    }
}
