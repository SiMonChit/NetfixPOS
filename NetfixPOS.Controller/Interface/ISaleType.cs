﻿using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Controller.Interface
{
    interface ISaleType
    {
        void Insert(SaleTypeModel saleType);
        void Update(SaleTypeModel saleType);
        void Delete(int id);
    }
}
