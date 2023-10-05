using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Controller.Common
{
    public class GlobalFunction
    {
        public static string GetComputerName()
        {
            return Dns.GetHostName();
        }
        public static string GetIPAddress()
        {
            string hostName = GetComputerName();
            return Dns.GetHostByName(hostName).AddressList[0].ToString();
        }
    }
}
