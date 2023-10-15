using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Microsoft.Reporting.WinForms;
using NetfixPOS.Controller;

namespace NetfixPOS.Report
{
    public partial class frm_StockReport : KryptonForm
    {
        public frm_StockReport()
        {
            InitializeComponent();
            _stock = new StockMasterController();
        }
        StockMasterController _stock;
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (cboFilter.SelectedIndex == 0) TopSellingStock();
            if (cboFilter.SelectedIndex == 1) MinimumBalanceStock();
            if (cboFilter.SelectedIndex == 2) GetAllStock();
        }
        private void GetAllStock()
        {
            DataTable dt = _stock.GetAllStock();
            ReportDataSource rds = new ReportDataSource("ds_StockList", dt);
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            string reportPath = Path.GetDirectoryName(Application.ExecutablePath).Remove(path.Length - 10) + @"\rdlc_File\rdlc_StockMasterReport.rdlc";

            rpv_StockReport.LocalReport.DataSources.Clear();
            rpv_StockReport.LocalReport.ReportPath = reportPath;
            rpv_StockReport.LocalReport.DataSources.Add(rds);

            this.rpv_StockReport.RefreshReport();
        }

        private void TopSellingStock()
        {

        }
        private void MinimumBalanceStock()
        {

        }
    }
}
