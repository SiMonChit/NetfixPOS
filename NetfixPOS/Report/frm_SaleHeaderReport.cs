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
    public partial class frm_SaleHeaderReport : KryptonForm
    {
        public frm_SaleHeaderReport()
        {
            InitializeComponent();
            _sale = new SaleController();
        }
        SaleController _sale;
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable dt = _sale.SaleHeaderSelectByDate(dtpFromDate.Value, dtpToDate.Value);
            ReportDataSource rds = new ReportDataSource("dt_saleheader", dt);
            rpv_SaleHeader.LocalReport.DataSources.Clear();
            rpv_SaleHeader.LocalReport.DataSources.Add(rds);
            this.rpv_SaleHeader.RefreshReport();
        }

        private void frm_SaleHeaderReport_Load(object sender, EventArgs e)
        {
            this.rpv_SaleHeader.RefreshReport();
        }
    }
}
