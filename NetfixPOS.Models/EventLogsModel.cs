using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Models
{
    public class EventLogsModel
    {
        public string LogType { get; set; }
        public DateTime LogDateTime { get; set; }
        public string Source { get; set; }
        public string LogMessage { get; set; }
        public string ErrMessage { get; set; }
        public string LocalIP { get; set; }
    }
}
