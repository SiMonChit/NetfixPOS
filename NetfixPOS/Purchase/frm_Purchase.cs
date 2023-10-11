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
using NetfixPOS.Models.DataSetFile;

namespace NetfixPOS.Purchase
{
    public partial class frm_Purchase : KryptonForm
    {
        public frm_Purchase()
        {
            InitializeComponent();
            _category = new CategoryController();
            _stock = new StockMasterController();
            purchasetb = new ds_Purchase.tbl_PurchaseDataTable();
            _purchase = new PurchaseController();
            purchase = new PurchaseModel();

            PopulateCategoryTreeView();
            trvCategory.AfterSelect += trvCategory_AfterSelect;
        }
        CategoryController _category;
        StockMasterController _stock;
        ds_Purchase.tbl_PurchaseDataTable purchasetb;
        PurchaseController _purchase;
        PurchaseModel purchase;
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
                    rootNode.Tag = Convert.ToInt32(row[0]);
                    trvCategory.Nodes.Add(rootNode);
                }
            }
            foreach (DataRow row in categories.Rows)
            {
                if (row[3] != DBNull.Value && trvCategory.Nodes.ContainsKey(row[3].ToString()))
                {
                    TreeNode childNode = new TreeNode(row[1].ToString());
                    childNode.Tag = Convert.ToInt32(row[0]);
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
            ds_Purchase.tbl_PurchaseRow pur_row = purchasetb.Newtbl_PurchaseRow();

            pur_row.PurchaseId = 0;
            pur_row.StockId = dgvStock.CurrentRow.Cells["colStock_Id"].Value.ToString();
            pur_row.StockName = dgvStock.CurrentRow.Cells["colStock_Name"].Value.ToString();
            pur_row.PurchasePrice = Convert.ToDecimal(dgvStock.CurrentRow.Cells["colPurchase_Price"].Value);
            pur_row.Qty = 1;
            pur_row.Amount = Convert.ToDecimal(pur_row.PurchasePrice * Convert.ToDecimal(pur_row.Qty));
            pur_row.Pur_Date = DateTime.Now;
            if (CheckPurchaseItem(pur_row.StockId))
            {
                MessageBox.Show("Update Qty for this Item", "Already Have", MessageBoxButtons.OK);
                return;
            }
            else
            {
                purchasetb.Addtbl_PurchaseRow(pur_row);
                AddToSaleItemView(purchasetb);
            }
            
        }
        private bool CheckPurchaseItem(string Stock_id)
        {
            string stockid = "";
            foreach (DataGridViewRow row in dgv_PurchaseItem.Rows)
            {
                stockid = row.Cells["colStockId"].Value.ToString();
                if(stockid == Stock_id)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        private void AddToSaleItemView(ds_Purchase.tbl_PurchaseDataTable purchasetb)
        {
            dgv_PurchaseItem.AutoGenerateColumns = false;
            dgv_PurchaseItem.DataSource = purchasetb;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            dgv_PurchaseItem.DataSource = null;
        }

        private void dgv_PurchaseItem_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GlobalFunction.GridView_DataBindingComplete(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_PurchaseItem.Rows)
            {
                ds_Purchase.tbl_PurchaseRow purchaseRow = purchasetb.Newtbl_PurchaseRow();
                purchaseRow.PurchaseId = Convert.ToInt32(row.Cells["colPurchaseId"].Value);
                purchaseRow.StockId = row.Cells["colStockId"].Value.ToString();
                purchaseRow.StockName = row.Cells["colStockName"].Value.ToString();
                purchaseRow.PurchasePrice = Convert.ToDecimal(row.Cells["colPurchasePrice"].Value);
                purchaseRow.Qty = Convert.ToInt32(row.Cells["colQty"].Value);
                purchaseRow.Amount = Convert.ToDecimal(row.Cells["colAmount"].Value);
                purchaseRow.Pur_Date = Convert.ToDateTime(row.Cells["colPur_Date"].Value);
                purchaseRow.UserID = 1;
                _purchase.Insert(purchaseRow);
            }
            dgv_PurchaseItem.DataSource = null;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            frm_ImportPurchase importPurchase = new frm_ImportPurchase();
            importPurchase.ShowDialog();
        }

        private void dgv_PurchaseItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = dgv_PurchaseItem.CurrentCell.RowIndex;
                string colName = dgv_PurchaseItem.Columns[dgv_PurchaseItem.CurrentCell.ColumnIndex].Name;

                if (colName == "colRemove")
                {
                    dgv_PurchaseItem.Rows.RemoveAt(dgv_PurchaseItem.CurrentRow.Index);
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void dgv_PurchaseItem_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_PurchaseItem.Rows[e.RowIndex].Cells["colStockName"].Value == null) return;

            try
            {
                if (dgv_PurchaseItem.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name.Equals("colQty"))
                {
                    if (dgv_PurchaseItem.Rows[e.RowIndex].Cells["colQty"].EditedFormattedValue.ToString() == string.Empty)
                    {
                        dgv_PurchaseItem.Rows[e.RowIndex].Cells["colQty"].Value = 0;
                    }
                    dgv_PurchaseItem.Rows[e.RowIndex].Cells["colAmount"].Value = Convert.ToInt32(dgv_PurchaseItem.Rows[e.RowIndex].Cells["colQty"].Value) * Convert.ToDecimal(dgv_PurchaseItem.Rows[e.RowIndex].Cells["colPurchasePrice"].EditedFormattedValue);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
