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
using NetfixPOS.Common;
using NetfixPOS.Controller;

namespace NetfixPOS.Payment
{
    public partial class frm_Payment : KryptonForm
    {
        public frm_Payment(string SaleId)
        {
            InitializeComponent();
            _sale = new SaleController();
            saleid = SaleId;
            GetSaleTotalAmount(SaleId);
        }
        SaleController _sale;
        string saleid = "";
        public frm_Payment()
        {
            InitializeComponent();
        }
        private void GetSaleTotalAmount(string SaleId)
        {
            txtTotalAmount.Text = _sale.SelectHeaderRow(SaleId).TotalAmount.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            frm_Print print = new frm_Print();
            print.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
