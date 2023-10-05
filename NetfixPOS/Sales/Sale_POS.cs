using NetfixPOS.Controller;
using NetfixPOS.Models;
using NetfixPOS.Payment;
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

namespace NetfixPOS.Sales
{
    public partial class Sale_POS : Form
    {
        public Sale_POS()
        {
            InitializeComponent();
            _sales = new SaleController();
        }
        SaleController _sales;
        bool isTable = false;

        private void RoomDataBind()
        {
            dgvSaleInvoice.AutoGenerateColumns = true;
            dgvSaleInvoice.DataSource = _sales.Room_ForSale();
            AdjustColumnOrder();
        }
        private void TableDataBind()
        {
            dgvSaleInvoice.AutoGenerateColumns = true;
            dgvSaleInvoice.DataSource = _sales.Table_ForSale();
            AdjustColumnOrder();
        }
        private void AdjustColumnOrder()
        {
            dgvSaleInvoice.Columns["colJoin"].DisplayIndex = dgvSaleInvoice.Columns.Count - 1;
            // ((DataTable)dgvSaleInvoice.DataSource).Columns.Count + 1;
        }
        private void btnRoom_Click(object sender, EventArgs e)
        {
            RoomDataBind();
            isTable = false;
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateVoucher_Click(object sender, EventArgs e)
        {

        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            TableDataBind();
            isTable = true;
            GlobalFunction.WriteLog("Sale POS : Table Click "+" Table Button Click");
        }

        private void btnRoom_Click_1(object sender, EventArgs e)
        {
            RoomDataBind();
            isTable = false;
            GlobalFunction.WriteLog("Sale POS : Room Click " + " Room Button Click");
        }

        private void btnNewVoucher_Click(object sender, EventArgs e)
        {
            int columnIndex = 2;
            string TableOrRoomNo = "";
            TableOrRoomNo = dgvSaleInvoice.CurrentRow.Cells[columnIndex].Value.ToString();
            GlobalFunction.WriteLog("Sale POS : NewVoucher Click " + TableOrRoomNo + " Open Voucher");
            Sale_Transaction sale_Transaction = new Sale_Transaction(TableOrRoomNo, isTable);
            sale_Transaction.ShowDialog();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            try
            {
                int columnIndex = 4;
                string SaleId = "";
                SaleId = dgvSaleInvoice.CurrentRow.Cells[columnIndex].Value.ToString();

                dsSaleSetup.SaleHeaderRow headerRow = _sales.SaleHeaderSelectById(SaleId);
                GlobalFunction.WriteLog("Sale POS : Payment Click " + SaleId + " To Payment");
                InvoicePayment payment = new InvoicePayment(headerRow);
                payment.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void dgvSaleInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            DataGridViewCheckBoxCell chkchecking;
            int rowIndex = dgvSaleInvoice.CurrentCell.RowIndex;
            string mainId = dgvSaleInvoice.Rows[rowIndex].Cells[4].Value.ToString();// get Main ID

            if (!string.IsNullOrEmpty(mainId))
            {
                string name = dgvSaleInvoice.Rows[rowIndex].Cells[2].Value.ToString();//get Table Name
                string otherId, otherName;
                foreach (DataGridViewRow row in dgvSaleInvoice.Rows)
                {
                    chkchecking = row.Cells["colJoin"] as DataGridViewCheckBoxCell;

                    if (Convert.ToBoolean(chkchecking.Value) == true)
                    {
                        otherId = row.Cells[4].Value.ToString();
                        otherName = row.Cells[2].Value.ToString();
                        if (otherId != mainId)
                        {
                            _sales.JoinTable(mainId, name, otherId, otherName);
                            GlobalFunction.WriteLog("Sale POS : JoinTable Click " + otherName + " From "+ name+" To");
                        }
                    }

                }
            }
            
        }

      

        private void dgvSaleInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = dgvSaleInvoice.CurrentCell.RowIndex;
                string colName = dgvSaleInvoice.Columns[dgvSaleInvoice.CurrentCell.ColumnIndex].Name;
                DataGridViewCheckBoxCell chkchecking = dgvSaleInvoice.Rows[rowIndex].Cells["colJoin"] as DataGridViewCheckBoxCell;
                if (colName == "colJoin")
                {


                    if (Convert.ToBoolean(chkchecking.Value) == true)
                    {
                        chkchecking.Value = false;
                    }
                    else
                    {
                        chkchecking.Value = true;
                    }
                }


            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnPaidConfirm_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            GlobalFunction.WriteLog("Sale POS : Update Click " + " Update Button Click");
        }
    }
}
