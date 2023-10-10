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
    public partial class frm_SlipVoucher : KryptonForm
    {
        public frm_SlipVoucher(string saleId)
        {
            InitializeComponent();
            _sale = new SaleController();
            SlipDataBind(saleId);

           

        }
        SaleController _sale;
        private void frm_SlipVoucher_Load(object sender, EventArgs e)
        {
            this.rpv_SlipVoucher.RefreshReport();
        }
        private void SlipDataBind(string saleId)
        {
            DataTable dt = _sale.GetSaleSlip(saleId);
            ReportDataSource rds = new ReportDataSource("dt_saleslip", dt);
            rpv_SlipVoucher.LocalReport.DataSources.Clear();
            rpv_SlipVoucher.LocalReport.DataSources.Add(rds);
            rpv_SlipVoucher.ProcessingMode = ProcessingMode.Local; // Use local processing mode
            //rpv_SlipVoucher.LocalReport.ReportPath = "YourReport.rdlc";

            this.rpv_SlipVoucher.RefreshReport();
            rpv_SlipVoucher.PrintDialog();
        }
    }
}
