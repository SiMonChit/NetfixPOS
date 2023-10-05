using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        public string EnrollNumber { get; set; }
        public string EmpName { get; set; }
        public int DepartmentId { get; set; }
        public Byte[] EmpImage { get; set; }
        public bool Gender { get; set; }
        public string PhoneNo { get; set; }
        public string BirthPlace { get; set; }
        public DateTime JoinDate { get; set; }
        public bool IsActive { get; set; }

    }
}
