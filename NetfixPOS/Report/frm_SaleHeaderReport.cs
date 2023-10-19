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
using System.IO;

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
            //All SaleInvoice (By Date)
            string reportPath = "";
            if (cboFilter.SelectedIndex == 0)
            {
                DataTable dt = _sale.SaleHeaderSelectByDate(dtpFromDate.Value, dtpToDate.Value,"ByDate");
                ReportDataSource rds = new ReportDataSource("dt_saleheader", dt);
                string path = Path.GetDirectoryName(Application.ExecutablePath);
                reportPath = Path.GetDirectoryName(Application.ExecutablePath).Remove(path.Length - 10) + @"\rdlc_File\rdlc_SaleHeader.rdlc";
                BindToReport(rds, reportPath);
            }
            else if(cboFilter.SelectedIndex == 1)//Weekly SaleInvoice
            {
                DataTable dt = _sale.SaleHeaderSelectByDate(dtpFromDate.Value, dtpToDate.Value,"ByWeekly");
                ReportDataSource rds = new ReportDataSource("dsWeekly", dt);
                string path = Path.GetDirectoryName(Application.ExecutablePath);
                reportPath = Path.GetDirectoryName(Application.ExecutablePath).Remove(path.Length - 10) + @"\rdlc_File\rdlc_WeeklySaleInvoice.rdlc";
                BindToReport(rds, reportPath);
            }
            else if (cboFilter.SelectedIndex == 2)//Monthly SaleInvoice
            {
                DataTable dt = _sale.SaleHeaderSelectByDate(dtpFromDate.Value, dtpToDate.Value, "ByMonthly");
                ReportDataSource rds = new ReportDataSource("dsMonthly", dt);
                string path = Path.GetDirectoryName(Application.ExecutablePath);
                reportPath = Path.GetDirectoryName(Application.ExecutablePath).Remove(path.Length - 10) + @"\rdlc_File\rdlc_MonthlySaleInvoice.rdlc";
                BindToReport(rds, reportPath);
            }
            else if (cboFilter.SelectedIndex == 3)//Yearly SaleInvoice
            {
                DataTable dt = _sale.SaleHeaderSelectByDate(dtpFromDate.Value, dtpToDate.Value, "ByYearly");
                ReportDataSource rds = new ReportDataSource("dt_saleheader", dt);
                string path = Path.GetDirectoryName(Application.ExecutablePath);
                reportPath = Path.GetDirectoryName(Application.ExecutablePath).Remove(path.Length - 10) + @"\rdlc_File\rdlc_WeeklySaleInvoice.rdlc";
                BindToReport(rds, reportPath);
            }


        }
        private void BindToReport(ReportDataSource rds, string reportPath)
        {
            rpv_SaleHeader.LocalReport.DataSources.Clear();
            rpv_SaleHeader.LocalReport.ReportPath = reportPath;
            rpv_SaleHeader.LocalReport.DataSources.Add(rds);
            this.rpv_SaleHeader.RefreshReport();
        }

        private void frm_SaleHeaderReport_Load(object sender, EventArgs e)
        {
            this.rpv_SaleHeader.RefreshReport();
        }
    }
}
