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
using NetfixPOS.Models.DataSetFile;
using NetfixPOS.Payment;

namespace NetfixPOS.Sales
{
    public partial class SaleDashboard : KryptonForm
    {
        public SaleDashboard()
        {
            InitializeComponent();
            _sales = new SaleController();
            _generate = new AutoGenerateController();
            _shop = new ShopController();

            GetSaleDate();
            ShowDataOnDashboard();
        }
        SaleController _sales;
        AutoGenerateController _generate;
        ShopController _shop;

        private int remainingTime = 200; // 60 minutes * 60 seconds
        bool isTable = false;

        private void GetSaleDate()
        {
            try
            {
                GlobalFunction.appInfo = _generate.GetAppInfo();
                dtpSaleDate.Value = Convert.ToDateTime(GlobalFunction.appInfo.Rows[0][1]);

                //GetShop Name
                ds_ShopInfo.ShopInfoRow shopinfo = _shop.GetShopName();
                lblShopName.Text = shopinfo.ShopName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "App Information", MessageBoxButtons.OK);
            }

        }

        private void ShowDataOnDashboard()
        {
            DataRow dataRow = _sales.GetdataForDashboard(dtpSaleDate.Value).Rows[0];
            lblNetAmount.Text = dataRow[0].ToString();
            lblTotalCash.Text = dataRow[1].ToString();
            lblTotalCredit.Text = dataRow[2].ToString();
            lblTotalSalesCount.Text = dataRow[3].ToString();
        }
        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = FormatTime(remainingTime);
            remainingTime -= 1;
            if (remainingTime < 0)
            {
                countdownTimer.Stop();
                //MessageBox.Show("Countdown is complete!");
                RoomDataBind();
                TableDataBind();
                remainingTime = 200; // Reset the remaining time
                countdownTimer.Start();
            }
        }
        private string FormatTime(int seconds)
        {
            TimeSpan ts = TimeSpan.FromSeconds(seconds);
            return $"{ts.Hours:D2}:{ts.Minutes:D2}:{ts.Seconds:D2}";
        }
        private void RoomDataBind()
        {
            dgvRoom.AutoGenerateColumns = false;
            dgvRoom.DataSource = _sales.Room_ForSale();
            AdjustColumnOrder(false);
        }
        private void TableDataBind()
        {
            dgvTable.AutoGenerateColumns = false;
            dgvTable.DataSource = _sales.Table_ForSale();
            AdjustColumnOrder(true);
        }
        private void AdjustColumnOrder(bool istable)
        {
            if(istable) dgvTable.Columns["coltableJoin"].DisplayIndex = dgvTable.Columns.Count - 1;
            else dgvRoom.Columns["colroomJoin"].DisplayIndex = dgvRoom.Columns.Count - 1;
            // ((DataTable)dgvSaleInvoice.DataSource).Columns.Count + 1;
        }

        private void kryptonDockableNavigator1_ContextAction(object sender, ComponentFactory.Krypton.Navigator.ContextActionEventArgs e)
        {
            if(e.Item.Text == "Table")
            {
                RoomDataBind();
            }
        }

        private void SaleDashboard_Load(object sender, EventArgs e)
        {
            countdownTimer.Start();
        }

        private void btnNewVoucher_Click(object sender, EventArgs e)
        {
            try
            {
                int columnIndex = 2;
                string TableOrRoomNo = "";
                if (isTable)
                {
                    TableOrRoomNo = dgvTable.CurrentRow.Cells[columnIndex].Value.ToString();
                }
                else
                {
                    TableOrRoomNo = dgvRoom.CurrentRow.Cells[columnIndex].Value.ToString();
                }
                GlobalFunction.WriteLog("Sale POS : NewVoucher Click " + TableOrRoomNo + " Open Voucher");
                Sale_Transaction sale_Transaction = new Sale_Transaction(TableOrRoomNo, isTable);
                sale_Transaction.ShowDialog();
            }catch(Exception ex)
            {
                return;
            }
            
        }

        private void dgvTable_Click(object sender, EventArgs e)
        {
            isTable = true;
        }

        private void dgvRoom_Click(object sender, EventArgs e)
        {
            isTable = false;
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            DataGridViewCheckBoxCell chkchecking;
            if (isTable)
            {
                int rowIndex = dgvTable.CurrentCell.RowIndex;
                string mainId = dgvTable.Rows[rowIndex].Cells[4].Value.ToString();// get Main ID

                if (!string.IsNullOrEmpty(mainId))
                {
                    string name = dgvTable.Rows[rowIndex].Cells[2].Value.ToString();//get Table Name
                    string otherId, otherName;
                    foreach (DataGridViewRow row in dgvTable.Rows)
                    {
                        chkchecking = row.Cells["coltableJoin"] as DataGridViewCheckBoxCell;

                        if (Convert.ToBoolean(chkchecking.Value) == true)
                        {
                            otherId = row.Cells[4].Value.ToString();
                            otherName = row.Cells[2].Value.ToString();
                            if (otherId != mainId)
                            {
                                _sales.JoinTable(mainId, name, otherId, otherName);
                                GlobalFunction.WriteLog("Sale POS : JoinTable Click " + otherName + " From " + name + " To");
                            }
                        }

                    }
                }
            }
            else
            {
                int rowIndex = dgvRoom.CurrentCell.RowIndex;
                string mainId = dgvRoom.Rows[rowIndex].Cells[4].Value.ToString();// get Main ID

                if (!string.IsNullOrEmpty(mainId))
                {
                    string name = dgvRoom.Rows[rowIndex].Cells[2].Value.ToString();//get Table Name
                    string otherId, otherName;
                    foreach (DataGridViewRow row in dgvTable.Rows)
                    {
                        chkchecking = row.Cells["colroomJoin"] as DataGridViewCheckBoxCell;

                        if (Convert.ToBoolean(chkchecking.Value) == true)
                        {
                            otherId = row.Cells[4].Value.ToString();
                            otherName = row.Cells[2].Value.ToString();
                            if (otherId != mainId)
                            {
                                _sales.JoinTable(mainId, name, otherId, otherName);
                                GlobalFunction.WriteLog("Sale POS : JoinRoom Click " + otherName + " From " + name + " To");
                            }
                        }

                    }
                }
            }
            
        }

        private void dgvRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvRoom.Columns[dgvRoom.CurrentCell.ColumnIndex].Name;
            string invid = "";
            if (colName == "colUpdate")
            {
                invid = dgvRoom.Rows[e.RowIndex].Cells["col_RoomSaleId"].Value.ToString();
                Sale_Transaction sale_Transaction = new Sale_Transaction(invid);
                sale_Transaction.ShowDialog();
            }
        }


        private void btnPayment_Click(object sender, EventArgs e)
        {
            int columnIndex = 4;
            string SaleId = "";
            if (isTable)
            {
                SaleId = dgvTable.CurrentRow.Cells[columnIndex].Value.ToString();
            }
            else
            {
                SaleId = dgvRoom.CurrentRow.Cells[columnIndex].Value.ToString();
            }
            GlobalFunction.WriteLog("Sale POS : Payment Click " + SaleId + " Payment Voucher");
            frm_Payment payment = new frm_Payment(SaleId);
            payment.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RoomDataBind();
            TableDataBind();
        }
    }
}
