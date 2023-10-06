using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Models
{
    public class RoomModel
    {
        public int RoomId { get; set; }
        public string RoomNo { get; set; }
        public string RoomName { get; set; }
        public int CompanyId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsDefault { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
