using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.DataAccess.Interface
{
    interface ISale
    {
        void HeaderInsert(dsSaleSetup.SaleHeaderRow headerRow, dsSaleSetup.SaleDetailDataTable detail_dt);
        void HeaderUpdate(dsSaleSetup.SaleHeaderRow headerRow, dsSaleSetup.SaleDetailDataTable detail_dt);
        void HeaderDelete(string id);


        void ItemInsert(string headerKey, dsSaleSetup.SaleDetailDataTable detail_dt, SqlConnection connection, SqlTransaction transaction);
        void ItemUpdate(string headerKey, dsSaleSetup.SaleDetailDataTable detail_dt, SqlConnection connection, SqlTransaction transaction);
    }
}
