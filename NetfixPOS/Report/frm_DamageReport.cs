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
    public partial class frm_DamageReport : KryptonForm
    {
        public frm_DamageReport()
        {
            InitializeComponent();
            _damage = new DamageController();
        }
        DamageController _damage;

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable dt = _damage.GetDamageList(dtpFromDate.Value, dtpToDate.Value);
            ReportDataSource rds = new ReportDataSource("Damage_ds", dt);
            rpv_Damage.LocalReport.DataSources.Clear();
            rpv_Damage.LocalReport.DataSources.Add(rds);
            this.rpv_Damage.RefreshReport();
        }

        private void frm_DamageReport_Load(object sender, EventArgs e)
        {

        }
    }
}
