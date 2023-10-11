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
using NetfixPOS.Models;

namespace NetfixPOS.Payment
{
    public partial class frm_Payment : KryptonForm
    {
        public frm_Payment(string SaleId)
        {
            InitializeComponent();
            _sale = new SaleController();
            _payment = new PaymentController();
            payment = new PaymentModel();

            saleid = SaleId;
            GetSaleTotalAmount(SaleId);
            txtPaidAmount.Focus();
        }
        SaleController _sale;
        PaymentController _payment;
        PaymentModel payment;
        string saleid = "";
        public frm_Payment()
        {
            InitializeComponent();
        }
        private void ClearControl()
        {
            txtPaidAmount.Clear();
            txtRemark.Clear();
            txtTotalAmount.Clear();
            cboPaymentType.SelectedIndex = 0;
        }
        private void GetSaleTotalAmount(string SaleId)
        {
            txtTotalAmount.Text = _sale.SelectHeaderRow(SaleId).TotalAmount.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboPaymentType.SelectedIndex < 0)
            {
                MessageBox.Show("Select PaymentType", "PaymentType", MessageBoxButtons.OK);
                return;
            }
            else
            {
                payment.PaymentType = cboPaymentType.Text;
                payment.PaySlipDate = DateTime.Now;
                payment.PaySlipNo = txtPaymentNo.Text;
                payment.PaidAmount = Convert.ToDecimal(txtPaidAmount.Text);
                payment.Remark = txtRemark.Text;
                payment.UserID = 1;

                int isSuccess = _payment.Insert(payment, saleid);
                if (isSuccess == 1)
                {
                    frm_Print print = new frm_Print(saleid);
                    print.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Someting worng", "Payment", MessageBoxButtons.OK);
                }
                
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
