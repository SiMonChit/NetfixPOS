using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Models
{
    public class CategoryModel
    {
        public int CategoryId {get;set;}
        public int ParentId { get; set; }
        public string CategoryName { get; set; }
        public bool IsActive { get; set; }
        public string CategoryType { get; set; }
    }
}
