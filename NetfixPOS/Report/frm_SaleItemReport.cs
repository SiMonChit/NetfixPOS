using Microsoft.Reporting.WinForms;
using NetfixPOS.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace NetfixPOS.Report
{
    public partial class frm_SaleItemReport : KryptonForm
    {
        public frm_SaleItemReport()
        {
            InitializeComponent();
            _sale = new SaleController();
        }
        SaleController _sale;
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable dt = _sale.SaleItemSelectByDate(dtpFromDate.Value, dtpToDate.Value);
            ReportDataSource rds = new ReportDataSource("dt_saleitem", dt);
            rpv_SaleItem.LocalReport.DataSources.Clear();
            rpv_SaleItem.LocalReport.DataSources.Add(rds);
            this.rpv_SaleItem.RefreshReport();
        }

        private void frm_SaleItemReport_Load(object sender, EventArgs e)
        {
            this.rpv_SaleItem.RefreshReport();
        }
    }
}
