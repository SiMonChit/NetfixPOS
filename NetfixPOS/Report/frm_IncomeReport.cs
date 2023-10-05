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

namespace NetfixPOS.Report
{
    public partial class frm_IncomeReport : Form
    {
        public frm_IncomeReport()
        {
            InitializeComponent();
            _income = new IncomeController();
        }
        IncomeController _income;

        private void frm_IncomeReport_Load(object sender, EventArgs e)
        {

            this.rpv_Income.RefreshReport();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable dt = _income.GetIncome_ListByDate(dtpFromDate.Value, dtpToDate.Value);
            ReportDataSource rds = new ReportDataSource("dt_Income", dt);
            rpv_Income.LocalReport.DataSources.Clear();
            rpv_Income.LocalReport.DataSources.Add(rds);
            this.rpv_Income.RefreshReport();
        }
    }
}
