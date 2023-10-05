using NetfixPOS.Controller.Interface;
using NetfixPOS.DataAccess;
using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Controller
{
    public class StockMasterController : IStock
    {
        private StockMasterDAL _stock;
        private EventLogsController _eventLogs;
        public StockMasterController()
        {
            _stock = new StockMasterDAL();
            _eventLogs = new EventLogsController();
        }
        public void Delete(string id)
        {
            try
            {
                _stock.Delete(id);
            }
            catch(Exception ex)
            {
                _eventLogs.AddLog("Delete", DateTime.Now, "StockEntry Form", "Delete StockId : " + id, ex.Message);
            }
        }

        public void Insert(StockModel stock, dsNewSetup.ConversionDataTable convDT)
        {
            try
            {
                _stock.Insert(stock, convDT);
            }
            catch(Exception ex)
            {
                _eventLogs.AddLog("Insert", DateTime.Now, "StockEntry Form", "Insert Stock", ex.Message);
            }
           
        }

        public void Update(StockModel stock, dsNewSetup.ConversionDataTable convDT)
        {
            try
            {
                _stock.Update(stock, convDT);
            }
            catch(Exception ex)
            {
                _eventLogs.AddLog("Update", DateTime.Now, "StockEntry Form", "Update Stock", ex.Message);
            }
            
        }

        public dsNewSetup.StockMasterRow SelectStockByStockID(string key)
        {
            return _stock.SelectStockByStockID(key);
        }
        public dsNewSetup.StockMasterDataTable GetStockList(string stockId)
        {
            return _stock.GetStockList(stockId);
        }
        public DataTable GetStockByCateoryId(int id)
        {
            return _stock.GetStockByCategoryId(id);
        }
    }
}
