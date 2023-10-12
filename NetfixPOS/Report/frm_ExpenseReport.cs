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
    public partial class frm_ExpenseReport : KryptonForm
    {
        public frm_ExpenseReport()
        {
            InitializeComponent();
            _expense = new ExpenseController();
        }
        ExpenseController _expense;

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable dt = _expense.GetExpense_ListByDate(dtpFromDate.Value, dtpToDate.Value);
            ReportDataSource rds = new ReportDataSource("dt_Expense", dt);
            rpv_Expense.LocalReport.DataSources.Clear();
            rpv_Expense.LocalReport.DataSources.Add(rds);
            this.rpv_Expense.RefreshReport();
        }

        private void frm_ExpenseReport_Load(object sender, EventArgs e)
        {
            this.rpv_Expense.RefreshReport();
        }
    }
}
