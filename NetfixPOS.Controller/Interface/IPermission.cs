﻿using NetfixPOS.Models.DataSetFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Controller.Interface
{
    interface IPermission
    {
        void Insert(ds_Permission.UserPermissionRow permissionRow);
        int Update(ds_Permission.UserPermissionRow permissionRow);
    }
}
