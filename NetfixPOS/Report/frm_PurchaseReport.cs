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
using Microsoft.Reporting.WinForms;
using NetfixPOS.Controller;

namespace NetfixPOS.Report
{
    public partial class frm_PurchaseReport : KryptonForm
    {
        public frm_PurchaseReport()
        {
            InitializeComponent();
            _purchase = new PurchaseController();
        }
        PurchaseController _purchase;
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable dt = _purchase.GetPurchaseList(dtpFromDate.Value, dtpToDate.Value);
            ReportDataSource rds = new ReportDataSource("Purchase_ds", dt);
            rpv_Purchase.LocalReport.DataSources.Clear();
            rpv_Purchase.LocalReport.DataSources.Add(rds);
            this.rpv_Purchase.RefreshReport();
        }

        private void frm_PurchaseReport_Load(object sender, EventArgs e)
        {

        }
    }
}
