using NetfixPOS.Common;
using NetfixPOS.Controller;
using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetfixPOS.Sales
{
    public partial class Sale_Transaction : Form, IFormBase
    {
        public Sale_Transaction()
        {
            InitializeComponent();
            _saletype = new SaleTypeController();
            _users = new UsersController();
            _category = new CategoryController();
            _stock = new StockMasterController();
            _generate = new AutoGenerateController();
            _employee = new EmployeeController();
            _sale = new SaleController();

            sale_detail = new dsSaleSetup.SaleDetailDataTable();
            sale_header = new dsSaleSetup.SaleHeaderDataTable();

            trvCategory.AfterSelect += trvCategory_AfterSelect;

            PopulateCategoryTreeView();
            SaleTypedataBind();
            UserdataBind();
            GetSaleInformation();
            WaiterDataBind();
        }

        //For Update Voucher
        public Sale_Transaction(string SaleId)
        {
            InitializeComponent();
            _saletype = new SaleTypeController();
            _users = new UsersController();
            _category = new CategoryController();
            _stock = new StockMasterController();
            _generate = new AutoGenerateController();
            _employee = new EmployeeController();
            _sale = new SaleController();

            sale_detail = new dsSaleSetup.SaleDetailDataTable();
            sale_header = new dsSaleSetup.SaleHeaderDataTable();

            trvCategory.AfterSelect += trvCategory_AfterSelect;

            PopulateCategoryTreeView();
            SaleTypedataBind();
            UserdataBind();
            //GetSaleInformation();
            WaiterDataBind();
            HeaderDataBind(SaleId);
            btnSave.Text = "Update";
        }

        //For New voucher from table or room
        public Sale_Transaction(string TableOrRoomNo, bool IsTable)
        {
            InitializeComponent();
            _saletype = new SaleTypeController();
            _users = new UsersController();
            _category = new CategoryController();
            _stock = new StockMasterController();
            _generate = new AutoGenerateController();
            _employee = new EmployeeController();
            _sale = new SaleController();

            sale_detail = new dsSaleSetup.SaleDetailDataTable();
            sale_header = new dsSaleSetup.SaleHeaderDataTable();

            trvCategory.AfterSelect += trvCategory_AfterSelect;

            PopulateCategoryTreeView();
            SaleTypedataBind();
            UserdataBind();
            GetSaleInformation();
            WaiterDataBind();
            txtTableOrRoom.Text = TableOrRoomNo;
            this.IsTable = IsTable;
            ShowForRoomSession(IsTable);
        }

        string sale_id="";
        bool IsTable = false;
        SaleTypeController _saletype;
        SaleController _sale;
        UsersController _users;
        CategoryController _category;
        StockMasterController _stock;
        EmployeeController _employee;
        AutoGenerateController _generate;
        dsSaleSetup.SaleDetailDataTable sale_detail;
        dsSaleSetup.SaleHeaderDataTable sale_header;
        decimal TotalAmount = 0;

        private void ShowForRoomSession(bool IsTable)
        {
            if (IsTable)
            {
                lblSinger.Visible = false;
                cboSinger.Visible = false;
                lblSession.Visible = false;
                lblStartTime.Visible = false;
                lblEndTime.Visible = false;
                cboSession.Visible = false;
                dtp_StartTime.Visible = false;
                dtp_EndTime.Visible = false;
            }
        }
        private void SaleTypedataBind()
        {
            cboSaleType.DataSource = _saletype.GetSaleType();
            cboSaleType.DisplayMember = "SaleTypeName";
            cboSaleType.ValueMember = "SaleTypeId";
        }
        private void GetSaleInformation()
        {
            try
            {
                GlobalFunction.appInfo = _generate.GetAppInfo();

                txtInvoiceNo.Text = _generate.GetGenerateNo("Invoice");
                txtSerPercent.Text = GlobalFunction.appInfo.Rows[0][3].ToString();
                txtDiscount.Text = GlobalFunction.appInfo.Rows[0][6].ToString();
                dtpInvoiceDate.Value = Convert.ToDateTime(GlobalFunction.appInfo.Rows[0][1]);
                txtRoomService.Text = GlobalFunction.appInfo.Rows[0][7].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "App Information", MessageBoxButtons.OK);
            }

        }
        private void UserdataBind()
        {
            cboSalePerson.DataSource = _users.GetUsers(0);
            cboSalePerson.DisplayMember = "UserName";
            cboSalePerson.ValueMember = "UserID";
        }
        private void WaiterDataBind()
        {
            cboWaiter.DataSource = _employee.GetEmpList(1);
            cboWaiter.DisplayMember = "EmpName";
            cboWaiter.ValueMember = "EmpId";
        }
        private void SingerDataBind()
        {

        }
        private void PopulateCategoryTreeView()
        {
            trvCategory.Nodes.Clear();
            DataTable categories = new DataTable();
            categories = _category.GetCategory(0,"Sale");

            foreach (DataRow row in categories.Rows)
            {
                if (row[3] == DBNull.Value)
                {
                    TreeNode rootNode = new TreeNode(row[1].ToString());
                    rootNode.Tag = Convert.ToInt32(row[0]); // Store the category ID in the Tag property
                    trvCategory.Nodes.Add(rootNode);
                }
            }

            // Create child nodes
            foreach (DataRow row in categories.Rows)
            {
                if (row[3] != DBNull.Value && trvCategory.Nodes.ContainsKey(row[3].ToString()))
                {
                    TreeNode childNode = new TreeNode(row[1].ToString());
                    childNode.Tag = Convert.ToInt32(row[0]); // Store the category ID in the Tag property
                    trvCategory.Nodes[row[3].ToString()].Nodes.Add(childNode);
                }
            }
        }

        private void trvCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                int categoryId = (int)e.Node.Tag;
                DataTable stocks = _stock.GetStockByCateoryId(categoryId);
                dgvStock.AutoGenerateColumns = false;
                dgvStock.DataSource = stocks;
            }
        }

        private void dgvStock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dsSaleSetup.SaleDetailRow tempItemRow = sale_detail.NewSaleDetailRow();
            tempItemRow.SaleDetailId = 0;
            tempItemRow.StockId = dgvStock.CurrentRow.Cells["colStockId"].Value.ToString();
            tempItemRow.StockName = dgvStock.CurrentRow.Cells["colStockName"].Value.ToString();
            tempItemRow.SalePrice = Convert.ToDecimal(dgvStock.CurrentRow.Cells["colSellingPrice"].Value);
            tempItemRow.Qty = 1;
            tempItemRow.Amount = Convert.ToDecimal(tempItemRow.SalePrice * Convert.ToDecimal(tempItemRow.Qty));

            if (txtTotalAmount.Text == "0") TotalAmount = tempItemRow.Amount;
            else TotalAmount += tempItemRow.Amount;

            txtTotalAmount.Text = TotalAmount.ToString();
            txtNetAmount.Text = Convert.ToString(TotalAmount + Convert.ToDecimal(txtServiceAmt.Text));
            sale_detail.AddSaleDetailRow(tempItemRow);
            AddToSaleItemView(sale_detail);
        }
        /// <summary>
        /// // Add Customer Id in combobox correctly
        /// </summary>
        /// <param name="InvoiceStatus"></param>
        /// <returns></returns>

        private dsSaleSetup.SaleHeaderRow GetSaleHeaders(string InvoiceStatus)
        {
            dsSaleSetup.SaleHeaderRow headerRow = sale_header.NewSaleHeaderRow();
            try
            {
                headerRow.InvNo = txtInvoiceNo.Text;
                headerRow.InvDate = dtpInvoiceDate.Value;//_generate.GetAuditDate(0);
                headerRow.UserID = Convert.ToInt32(cboSalePerson.SelectedValue);
                headerRow.CustomerId = 1;
                //Convert.ToInt32(cboCustomer.SelectedValue);
                headerRow.SaleTypeId = Convert.ToInt32(cboSaleType.SelectedValue);
                if (IsTable) { headerRow.TableNo = txtTableOrRoom.Text; headerRow.RoomNo = ""; }
                else { headerRow.RoomNo = txtTableOrRoom.Text; headerRow.TableNo = ""; }
                headerRow.Remark = txtRemark.Text;
                headerRow.IsFOC = chkFOC.Checked;
                headerRow.DiscountAmount = Convert.ToDecimal(txtDiscount.Text);
                headerRow.DeliveryFee = Convert.ToDecimal(txtDeliveryFee.Text);
                headerRow.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);// Convert.ToDecimal(txtTotal.Text.Trim());
                headerRow.NetAmount = Convert.ToDecimal(txtNetAmount.Text);

                headerRow.WaiterName = cboWaiter.Text;
                headerRow.PrintDate = DateTime.Now;
                headerRow.Singer = cboSinger.Text;
                headerRow.BalanceAmount = Convert.ToDecimal(Convert.ToDecimal(txtTotalAmount.Text) - Convert.ToDecimal(txtPaidAmount.Text));
                headerRow.C_tax = Convert.ToDecimal(txtSerPercent.Text);
                headerRow.AdvanceAmount = Convert.ToDecimal(txtPaidAmount.Text);
                headerRow.DueAmount = 0;
                headerRow.InvoiceStatus = InvoiceStatus;

                return headerRow;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private dsSaleSetup.SaleDetailDataTable GetSaleItems()
        {
            try
            {
                dsSaleSetup.SaleDetailRow detail_row;
                sale_detail = new dsSaleSetup.SaleDetailDataTable();
                //sale_detail = null;

                foreach (DataGridViewRow row in dgvSaleItem.Rows)
                {
                    detail_row = sale_detail.NewSaleDetailRow();

                    if (row.Cells["colSaleStockName"].Value == null)
                    {
                        break;
                    }
                    detail_row.SaleDetailId = Convert.ToInt32(row.Cells["colSaleDetailId"].Value);
                    detail_row.StockId = Convert.ToString(row.Cells["colSaleStockId"].Value);
                    detail_row.StockName = row.Cells["colSaleStockName"].Value.ToString();
                    detail_row.SalePrice = Convert.ToDecimal(row.Cells["colSalePrice"].Value);
                    detail_row.Qty = Convert.ToInt32(row.Cells["colQty"].Value);
                    detail_row.Amount = Convert.ToInt32(row.Cells["colAmount"].Value);
                    detail_row.IsFOC = false;//Convert.ToBoolean(row.Cells["colIsFOC"].Value);

                    detail_row.Discount = 0;
                    detail_row.CategoryID = 0;
                    detail_row.Serial = 0;
                    detail_row.ConvensionId = "";

                    sale_detail.AddSaleDetailRow(detail_row);
                }

                return sale_detail;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void AddToSaleItemView(dsSaleSetup.SaleDetailDataTable sale_detail)
        {
            dgvSaleItem.AutoGenerateColumns = false;
            dgvSaleItem.DataSource = sale_detail;
        }

        private void dgvSaleItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = dgvSaleItem.CurrentCell.RowIndex;
                string colName = dgvSaleItem.Columns[dgvSaleItem.CurrentCell.ColumnIndex].Name;

                if (colName == "colRemove")
                {
                    TotalAmount -= Convert.ToDecimal(dgvSaleItem.CurrentRow.Cells["colAmount"].Value);
                    //itemsid = Convert.ToString(dgvSaleItem.CurrentRow.Cells["colItemsID"].Value);
                    //lblNetAmount.Text = string.Format("{0:#,##0} Ks", NetAmount);
                    txtTotalAmount.Text = TotalAmount.ToString();
                    dgvSaleItem.Rows.RemoveAt(dgvSaleItem.CurrentRow.Index);

                    if (txtTotalAmount.Text == "0")
                    {
                        txtPaidAmount.Text = "0";
                    }
                    else
                    {
                        //txtCreditAmount.Text = (Convert.ToDecimal(txtTotalAmount.Text) - nudPaidAmount.Value).ToString();
                    }

                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void dgvSaleItem_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSaleItem.Rows[e.RowIndex].Cells["colSaleStockName"].Value == null) return;

            try
            {
                if (dgvSaleItem.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name.Equals("colQty"))
                {
                    if (dgvSaleItem.Rows[e.RowIndex].Cells["colQty"].EditedFormattedValue.ToString() == string.Empty)
                    {
                        dgvSaleItem.Rows[e.RowIndex].Cells["colQty"].Value = 0;
                    }
                    dgvSaleItem.Rows[e.RowIndex].Cells["colAmount"].Value = Convert.ToInt32(dgvSaleItem.Rows[e.RowIndex].Cells["colQty"].Value) * Convert.ToDecimal(dgvSaleItem.Rows[e.RowIndex].Cells["colSalePrice"].EditedFormattedValue);

                    Show_TotalAmount(e);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Show_TotalAmount(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TotalAmount = 0;
                string SerTax = txtServiceAmt.Text;
                TotalAmount = (TotalAmount * Convert.ToDecimal(SerTax)) + TotalAmount;

                foreach (DataGridViewRow row in dgvSaleItem.Rows)
                {
                    TotalAmount += Convert.ToDecimal(row.Cells["colAmount"].Value);
                }


                txtTotalAmount.Text = TotalAmount.ToString();
                txtNetAmount.Text = TotalAmount.ToString();

            }
        }

        private void dgvSaleItem_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GlobalFunction.GridView_DataBindingComplete(sender, e);
        }

        private void txtDeliveryFee_Leave(object sender, EventArgs e)
        {
            try
            {
                TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
                TotalAmount = TotalAmount + Convert.ToDecimal(txtDeliveryFee.Text);
                txtTotalAmount.Text = TotalAmount.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            txtTotalAmount.Text = (Convert.ToDecimal(txtTotalAmount.Text) - Convert.ToDecimal(txtDiscount.Text)).ToString();
        }

        private void txtPaidAmount_Leave(object sender, EventArgs e)
        {
            txtBalanceAmount.Text = (Convert.ToDecimal(txtTotalAmount.Text) - Convert.ToDecimal(txtPaidAmount.Text)).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Update")
            {

            }
            else SaveHeaderDetail("Save");
        }

        private void btnPendding_Click(object sender, EventArgs e)
        {
            SaveHeaderDetail("Pending");
        }
        private bool CheckRequireFill()
        {
            if (dgvSaleItem.Rows.Count < 0)
            {
                MessageBox.Show("ကုန်ပစ္စည်း အမည်ကို ဖြည့်ပါ");
                return false;
            }

            return true;
        }
        private void SaveHeaderDetail(string InvoiceStatus)
        {
            if (CheckRequireFill())
            {
                try
                {
                    if (MessageBox.Show(this, "Are you sure to save?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        dsSaleSetup.SaleHeaderRow headerRow = GetSaleHeaders(InvoiceStatus);
                        dsSaleSetup.SaleDetailDataTable detail_dt = GetSaleItems();

                        _sale.Insert(headerRow, detail_dt);

                        //SaleVoucher saleVoucher = new SaleVoucher(txtVoucherNo.Text);

                        MessageBox.Show("Save Successfully");
                        ClearControl();
                        _generate.AutoCodeGenerate("INV");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        public void ClearControl()
        {
            txtTableOrRoom.Clear();
            txtPaidAmount.Clear();
            txtDeliveryFee.Clear();
            txtDiscount.Clear();
            txtRemark.Clear();
            txtTotalAmount.Clear();
            txtNetAmount.Clear();
            txtBalanceAmount.Clear();
            chkFOC.Checked = false;
            dgvSaleItem.DataSource = null;
        }

        public void DataBind()
        {
            throw new NotImplementedException();
        }
        private void HeaderDataBind(string SaleId)
        {
            dsSaleSetup.SaleHeaderRow headerRow = _sale.SelectHeaderRow(SaleId);
            sale_id = headerRow.SaleId;
            txtInvoiceNo.Text = headerRow.InvNo;
            dtpInvoiceDate.Value = headerRow.InvDate;
            cboSalePerson.SelectedValue = headerRow.UserID;
            cboCustomer.SelectedValue = headerRow.CustomerId;
            cboSaleType.SelectedValue = headerRow.SaleTypeId;
            if(headerRow.TableNo!=null) txtTableOrRoom.Text = headerRow.TableNo;
            else txtTableOrRoom.Text = headerRow.RoomNo;
            txtRemark.Text = headerRow.Remark;
            txtDiscount.Text = headerRow.DiscountAmount.ToString();
            txtDeliveryFee.Text = headerRow.DeliveryFee.ToString();
            txtSerPercent.Text = headerRow.C_tax.ToString();
            txtServiceAmt.Text = ((headerRow.C_tax / 100) * headerRow.TotalAmount).ToString();
            chkFOC.Checked = headerRow.IsFOC;
            ItemDataBind(SaleId);
        }
        private void ItemDataBind(string SaleId)
        {
            sale_detail = new dsSaleSetup.SaleDetailDataTable();
            sale_detail = _sale.SaleDetailSelectByHeaderId(SaleId);
            AddToSaleItemView(sale_detail);
        }

        private void cboSession_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cboSession.SelectedIndex == 0)
            {
                dtp_StartTime.Value = DateTime.Now;
                dtp_EndTime.Value = DateTime.Now.AddHours(1);
            }
            else if(cboSession.SelectedIndex == 1)
            {
                dtp_StartTime.Value = DateTime.Now;
                dtp_EndTime.Value = DateTime.Now.AddHours(2);
            }
            else if(cboSession.SelectedIndex == 2)
            {
                dtp_StartTime.Value = DateTime.Now;
                dtp_EndTime.Value = DateTime.Now.AddHours(3);
            }
            else if (cboSession.SelectedIndex == 3)
            {
                dtp_StartTime.Value = DateTime.Now;
                dtp_EndTime.Value = DateTime.Now.AddHours(4);
            }
            else if (cboSession.SelectedIndex == 4)
            {
                dtp_StartTime.Value = DateTime.Now;
                dtp_EndTime.Value = DateTime.Now.AddHours(5);
            }
        }
    }
}
