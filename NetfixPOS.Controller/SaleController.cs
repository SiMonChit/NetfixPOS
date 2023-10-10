using NetfixPOS.Controller.Interface;
using NetfixPOS.DataAccess;
using NetfixPOS.Models;
using NetfixPOS.Models.DataSetFile;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Controller
{
    public class SaleController : ISale
    {
        private SaleDAL _sale;
        private EventLogsController _eventLogs;
        public SaleController()
        {
            _sale = new SaleDAL();
            _eventLogs = new EventLogsController();
        }

        public DataTable Table_ForSale()
        {
            return _sale.Table_ForSale();
        }


        public DataTable Room_ForSale()
        {
            return _sale.Room_ForSale();
        }

        public void Insert(dsSaleSetup.SaleHeaderRow headerRow, dsSaleSetup.SaleDetailDataTable detail_dt)
        {
            try
            {
                _sale.HeaderInsert(headerRow, detail_dt);

                if (headerRow.InvoiceStatus == "Pending")
                {
                    _eventLogs.AddLog("Pending", DateTime.Now, "Sale Transaction", "Sale Invoice Pending" + headerRow.InvNo + " " + headerRow.TotalAmount.ToString(), "Pending Success");

                    foreach (dsSaleSetup.SaleDetailRow detailRow in detail_dt.Rows)
                    {
                        _eventLogs.AddLog("pending", DateTime.Now, "Sale Transaction", "SaleItem Pending" + headerRow.InvNo + " " + headerRow.TotalAmount.ToString(), "Pending Success");
                    }
                }
                else
                {
                    _eventLogs.AddLog("Save", DateTime.Now, "Sale Transaction", "Sale Invoice Save" + headerRow.InvNo + " " + headerRow.TotalAmount.ToString(), "Save Success");

                    foreach (dsSaleSetup.SaleDetailRow detailRow in detail_dt.Rows)
                    {
                        _eventLogs.AddLog("pending", DateTime.Now, "Sale Transaction", "SaleItem Save" + detailRow.StockId + " " + detailRow.Qty.ToString() + " " + detailRow.Amount.ToString(), "Save Success");
                    }
                }

            }
            catch (Exception ex)
            {

            }

        }

        public void Update(dsSaleSetup.SaleHeaderRow headerRow, dsSaleSetup.SaleDetailDataTable detail_dt)
        {
            _sale.HeaderUpdate(headerRow, detail_dt);
        }

        #region Jointable 
        public void JoinTable(string id, string name, string otherId, string otherName)
        {
            _sale.JoinTable(id, name, otherId, otherName);
        }
        #endregion

        #region Printer
        public dsSaleSetup.SaleHeaderRow SaleHeaderSelectById(string id)
        {
            return _sale.SaleHeaderSelectById(id);
        }
        /// <summary>
        /// Add By Nay To print slip
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public dsSaleSetup.SaleHeaderSlipRow SaleHeaderSlipSelectById(string id)
        {
            return _sale.SaleHeaderSlipSelectById(id);
        }

        public dsSaleSetup.SaleDetailDataTable SaleDetailSelectByHeaderId(string headerId)
        {
            return _sale.SaleDetailSelectByHeaderId(headerId);
        }

        public DataTable SaleHeaderSelectByDate(DateTime fromDate, DateTime toDate)
        {
            return _sale.SaleHeaderSelectByDate(fromDate, toDate);
        }
        /// <summary>
        /// Add By Nay to get Sale Invoice Detail for Slip
        /// </summary>
        /// <param name="saleid"></param>
        /// <returns></returns>
        public ds_SaleSlip.tbl_SaleSlipDataTable GetSaleSlip(string saleid)
        {
            return _sale.GetSaleSlip(saleid);
        }

        public dsSaleSetup.SaleHeaderRow SelectHeaderRow(string saleid)
        {
            return _sale.SelectHeaderRow(saleid);
        }

        #endregion

        #region SaleItem Select
        public DataTable SaleItemSelectByDate(DateTime fromDate, DateTime toDate)
        {
            return _sale.SaleItemSelectByDate(fromDate, toDate);
        }

        #endregion

    }
}
