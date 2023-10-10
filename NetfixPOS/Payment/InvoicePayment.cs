using NetfixPOS.Controller;
using NetfixPOS.Models;
using NetfixPOS.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetfixPOS.Payment
{
    public partial class InvoicePayment : Form
    {
        public InvoicePayment(dsSaleSetup.SaleHeaderRow headerRow)
        {
            InitializeComponent();

            _saletype = new SaleTypeController();
            _sale = new SaleController();
            _payment = new PaymentController();
            payment = new PaymentModel();
            _generate = new AutoGenerateController();

            SaleHeaderDataBind(headerRow);
            SaleTypedataBind();
            GetInvoiceNo();
            BindPrinterDevice();
        }
        SaleTypeController _saletype;
        SaleController _sale;
        PaymentController _payment;
        PaymentModel payment;
        AutoGenerateController _generate;
        string saleid = "";
        int isSuccess = 0;
        private void SaleTypedataBind()
        {
            cboSaleType.DataSource = _saletype.GetSaleType();
            cboSaleType.DisplayMember = "SaleTypeName";
            cboSaleType.ValueMember = "SaleTypeId";
        }
        private void GetInvoiceNo()
        {
            txtPaymentNo.Text = _generate.GetGenerateNo("Payment");
        }
        private void SaleHeaderDataBind(dsSaleSetup.SaleHeaderRow headerRow)
        {
            saleid = headerRow.SaleId;
            txtBalanceAmount.Text = headerRow.BalanceAmount.ToString();
            txtTotalAmount.Text = headerRow.TotalAmount.ToString();
            txtPaidAmount.Text = headerRow.AdvanceAmount.ToString();
            //txtPaymentNo.Text = headerRow.InvNo;
            txtDiscount.Text = headerRow.DiscountAmount.ToString();
            txtDeliveryFee.Text = headerRow.DeliveryFee.ToString();
            txtSerPercent.Text = "0";
            txtPaidAmount.Text = headerRow.C_tax.ToString();
            if (headerRow.TableNo != "") txtTableOrRoom.Text = headerRow.TableNo;
            if (headerRow.RoomNo != "") txtTableOrRoom.Text = headerRow.RoomNo;
            SaleItemDataBind(headerRow.SaleId);
        }
        private void SaleItemDataBind(string headerId)
        {
            dgvSaleItem.AutoGenerateColumns = false;
            dgvSaleItem.DataSource = _sale.SaleDetailSelectByHeaderId(headerId);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }

        private void txtPaidAmount_Leave(object sender, EventArgs e)
        {

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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            payment.PaySlipDate = DateTime.Now;
            payment.PaySlipNo = txtPaymentNo.Text;
            payment.PaidAmount = Convert.ToDecimal(txtPaidAmount.Text);
            payment.UserID = 1;
            isSuccess = _payment.Insert(payment,"");
            if (isSuccess != 0)
            {
                //frm_SlipVoucher frm_Slip = new frm_SlipVoucher(saleid);
                //frm_Slip.ShowDialog();

                // Create a PrintDialog to configure printing settings
                PrintDialog printDialog = new PrintDialog();
                PrintDocument printDocument = new PrintDocument();
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.PrinterSettings.PrinterName = cboPrinter.Text;
                    printDocument.Print();
                }

            }
        }
    }
}
