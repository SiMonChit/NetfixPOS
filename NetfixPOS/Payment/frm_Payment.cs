using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
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
            _generate = new AutoGenerateController();

            saleid = SaleId;
            GetSaleTotalAmount(SaleId);
            txtPaidAmount.Focus();
            GetTemplateFile();
            BindPrinterDevice();
        }
        SaleController _sale;
        PaymentController _payment;
        PaymentModel payment;
        string saleid = "";
        AutoGenerateController _generate;
        public frm_Payment()
        {
            InitializeComponent();
            txtPaidAmount.Focus();
            GetTemplateFile();
            BindPrinterDevice();
            _generate = new AutoGenerateController();
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
            txtPaymentNo.Text = _generate.GetGenerateNo("Payment");
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

                //frm_Print print = new frm_Print(saleid);
                //print.ShowDialog();

                int isSuccess = _payment.Insert(payment, saleid);
                if (isSuccess > 0)
                {
                    ClearControl();
                    MessageBox.Show("Payment successful", "Payment", MessageBoxButtons.OK);
                    //frm_Print print = new frm_Print(saleid);
                    //print.ShowDialog();
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

        private void frm_Payment_Activated(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
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
                if (isSuccess > 0)
                {
                    GlobalPrintFunction globalPrint = new GlobalPrintFunction();
                    globalPrint.Print(saleid, cboTemplate.Text, Convert.ToInt32(txtPrintQty.Text));
                    ClearControl();
                }
                else
                {
                    MessageBox.Show("Someting worng", "Payment", MessageBoxButtons.OK);
                }

            }
            
        }

        private void BindPrinterDevice()
        {
            cboPrinter.Items.Clear();

            foreach (string printerName in PrinterSettings.InstalledPrinters)
            {
                PrinterSettings printerSettings = new PrinterSettings();
                printerSettings.PrinterName = printerName;
                string deviceID = printerSettings.PrinterName;
                cboPrinter.Items.Add(new PrinterInfo(deviceID, printerName));
            }
            cboPrinter.DisplayMember = "DisplayName";
            cboPrinter.ValueMember = "DeviceID";
        }
        private void GetTemplateFile()
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            string folderPath = Path.GetDirectoryName(Application.ExecutablePath).Remove(path.Length - 10) + @"\PrintTemplate";

            if (Directory.Exists(folderPath))
            {
                string[] rdlcFiles = Directory.GetFiles(folderPath, "*.rdlc");
                List<string> rdlcFileNames = new List<string>();
                foreach (string filePath in rdlcFiles)
                {
                    rdlcFileNames.Add(Path.GetFileName(filePath));
                }
                cboTemplate.Items.AddRange(rdlcFileNames.ToArray());
            }
            else
            {
                MessageBox.Show("Folder does not exist.");
            }
        }
    }
}
