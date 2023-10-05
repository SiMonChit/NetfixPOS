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

namespace NetfixPOS.Admin
{
    public partial class EventLogs : Form
    {
        public EventLogs()
        {
            InitializeComponent();
            _eventLogs = new EventLogsController();
        }
        EventLogsController _eventLogs;

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable dt = _eventLogs.ReadLog(dtpFromDate.Value, dtpToDate.Value);
            ReportDataSource rds = new ReportDataSource("dt_EventLogs", dt);
            rpv_EventLogs.LocalReport.DataSources.Clear();
            rpv_EventLogs.LocalReport.DataSources.Add(rds);
            this.rpv_EventLogs.RefreshReport();
        }

        private void EventLogs_Load(object sender, EventArgs e)
        {

            this.rpv_EventLogs.RefreshReport();
        }
    }
}
