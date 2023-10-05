using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Models
{
    public class UsersModel
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public Byte[] UserImage { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Password_Salt { get; set; }
        public bool IsLogin { get; set; }
        public bool IsActive { get; set; }
    }
}
