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
using NetfixPOS.Common;
using NetfixPOS.Controller;
using NetfixPOS.rtp_File;

namespace NetfixPOS.Admin
{
    public partial class frm_EndOfDay : KryptonForm
    {
        EndOfDayController _endofday;
        public frm_EndOfDay()
        {
            InitializeComponent();
            _endofday = new EndOfDayController();

            EOD_DataBind();
            DataBindForDayEnd(dtp_eod_detail.Value);
        }

        private void DataBindForDayEnd(DateTime end_of_day)
        {
            dgvEndOfDay_Audit.AutoGenerateColumns = false;
            dgvEndOfDay_Audit.DataSource = _endofday.GetSaleDetailForDayEnd(1, end_of_day);
        }
        private void EOD_DataBind()
        {
            dgvEndOfDay.AutoGenerateColumns = false;
            dgvEndOfDay.DataSource = _endofday.GetListEndOfDay(0);
        }

        private void dtp_eod_detail_ValueChanged(object sender, EventArgs e)
        {
            DataBindForDayEnd(dtp_eod_detail.Value);
        }

        private void btnDayEnd_Click(object sender, EventArgs e)
        {
            GlobalFunction.WriteLog("EndOfDay " + " End Of Day Button Click to day end" + GlobalFunction.LoginUser.UserName);
        }
    }
}
