using NetfixPOS.Models.DataSetFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.DataAccess.Interface
{
    interface IPermission
    {
        void Insert(ds_Permission.UserPermissionRow row);
        int Update(ds_Permission.UserPermissionRow row);
    }
}
