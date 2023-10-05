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

namespace NetfixPOS.NewSetup
{
    public partial class StockItem : Form, IFormBase
    {
        public StockItem()
        {
            InitializeComponent();
            _stock = new StockMasterController();
            _conversion = new ConversionController();
            _category = new CategoryController();
            stock = new StockModel();
            _currency = new CurrencyController();
            convDT = new dsNewSetup.ConversionDataTable();
            BindCategory();
            BindCurrency();
            unitConfig = new DataTable();
            unitConfig.Columns.Add("UnitName");
            unitConfig.Columns.Add("UnitID");
            DataBind();
        }
        StockMasterController _stock;
        ConversionController _conversion;
        CurrencyController _currency;
        CategoryController _category;
        string STOCK_ID = "";
        DataTable unitConfig;
        StockModel stock;
        dsNewSetup.ConversionDataTable convDT;
        /*Need to get id*/
        AutoCompleteStringCollection auto_unit;
        List<string> unitId;
        List<decimal> unitDefaultQty;
        /**/

        private void BindUnit()
        {
            DataTable dt = new UnitController().GetUint();

            cboDefault.DataSource = dt;
            cboDefault.DisplayMember = "Unit";
            cboDefault.ValueMember = "UnitID";

            auto_unit = new AutoCompleteStringCollection();
            unitId = new List<string>();
            unitDefaultQty = new List<decimal>();

            foreach (DataRow row in dt.Rows)
            {
                auto_unit.Add(row[0].ToString());
                unitId.Add(row[0].ToString());
                unitDefaultQty.Add(Convert.ToDecimal(row[2]));
            }

        }
        private void BindCategory()
        {
            cboCategory.DataSource = _category.GetCategory(0);
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryId";
        }
        private void BindCurrency()
        {
            cboSaleCur.DataSource = _currency.GetCurrency(0);
            cboSaleCur.DisplayMember = "Currency";
            cboSaleCur.ValueMember = "CurrencyId";
        }
        private void btnConfUnit_Click(object sender, EventArgs e)
        {
            ConfitUnit frm = new ConfitUnit(unitConfig);
            if (frm.ShowDialog(this) == System.Windows.Forms.DialogResult.Yes)
            {
                unitConfig = frm.UnitData;

                int count = unitConfig.Rows.Count;

                if (count > 0)
                {
                    //dgvUnitConversion.RowCount = count;

                    foreach (DataGridViewColumn col in dgvUnitConversion.Columns)
                    {
                        col.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }

                    dgvUnitConversion.AutoGenerateColumns = false;
                    dgvUnitConversion.DataSource = unitConfig.Copy();

                    cboDefault.DataSource = unitConfig;
                    cboDefault.DisplayMember = "UnitName";
                    cboDefault.ValueMember = "UnitID";

                    cboMaxUnit.DataSource = unitConfig.Copy();
                    cboMaxUnit.DisplayMember = "UnitName";
                    cboMaxUnit.ValueMember = "UnitID";

                    cboMinUnit.DataSource = unitConfig.Copy();
                    cboMinUnit.DisplayMember = "UnitName";
                    cboMinUnit.ValueMember = "UnitID";

                    DataGridViewCell cell = dgvUnitConversion.Rows[0].Cells[colCQty.Index];
                    cell.ReadOnly = true;
                    cell.Value = 1;

                }
                else
                {
                    dgvUnitConversion.DataSource = 0;
                    cboDefault.DataSource = null;
                }

            }
        }

        public void ClearControl()
        {
            STOCK_ID = "";

            txtCode.Clear();
            txtCode.Focus();
            txtName.Clear();
            picStock.Image = null;

            cboDefault.SelectedIndex = -1;
            chbDiscontinue.Checked = false;

            cboDefault.DataSource = null;
            cboMaxUnit.DataSource = null;
            cboMinUnit.DataSource = null;
            dgvUnitConversion.DataSource = null;
            unitConfig.Clear();

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }

        public void ControlDataBind()
        {
            #region Stock
            dsNewSetup.StockMasterRow stockRow = _stock.SelectStockByStockID(STOCK_ID);

            cboCategory.SelectedValue = stockRow.CategoryId;

            chbDiscontinue.Checked = stockRow.Discontinue;
            txtCode.Text = stockRow.StockCode;
            txtName.Text = stockRow.StockName;
            cboSaleCur.SelectedValue = stockRow.SaleCurrencyId;

            numMax.Value = stockRow.Maxqty;
            numMin.Value = stockRow.Minqty;
            nudSellingPrice.Value = stockRow.SellingPrice;
            nudPurchasePrice.Value = stockRow.PurchasePrice;
            picStock.Image = GlobalFunction.ConvertByteArrayToImage(stockRow.StockIcon);
            chkIsStore.Checked = stockRow.IsStore;
            //cboCategory.SelectedValue = Convert.ToInt32(stockRow.CategoryId);

            #endregion
            #region Unit Conversion
            dsNewSetup.SelectConversionDataTable convDt = _conversion.ConversionSelectByStockId(STOCK_ID);
            dgvUnitConversion.AutoGenerateColumns = false;
            dgvUnitConversion.DataSource = convDt;
            #endregion

            #region For Unit Combo
            foreach (dsNewSetup.SelectConversionRow row in convDt)
            {
                unitConfig.Rows.Add(
                        new object[]
                        {
                            row.UnitName,
                            row.UnitId
                        }
                    );
            }

            cboDefault.DisplayMember = "UnitName";
            cboDefault.ValueMember = "UnitID";
            cboDefault.DataSource = unitConfig;

            cboMinUnit.DisplayMember = "UnitName";
            cboMinUnit.ValueMember = "UnitID";
            cboMinUnit.DataSource = unitConfig.Copy();

            cboMaxUnit.DisplayMember = "UnitName";
            cboMaxUnit.ValueMember = "UnitID";
            cboMaxUnit.DataSource = unitConfig.Copy();

            cboDefault.SelectedValue = stockRow.DefaultUnit;
            cboMinUnit.SelectedValue = stockRow.MinUnitId;
            cboMaxUnit.SelectedValue = stockRow.MaxUnitId;
            #endregion

            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private AutoCompleteStringCollection BindUnitCollection()
        {
            DataTable dt = new UnitController().GetUint();

            AutoCompleteStringCollection _unit = new AutoCompleteStringCollection();

            foreach (DataRow row in dt.Rows)
            {
                _unit.Add(row[1].ToString());
            }

            return _unit;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboDefault.SelectedIndex == -1) return;

            #region Stock

            stock.StockCode = txtCode.Text.Trim();
            stock.StockName = txtName.Text.Trim();
            stock.CategoryId = Convert.ToInt32(cboCategory.SelectedValue);
            stock.SaleCurrencyId = Convert.ToInt32(cboSaleCur.SelectedValue);
            stock.Minqty = numMin.Value;
            stock.Maxqty = numMax.Value;
            stock.MinUnitId = Convert.ToInt32(cboMinUnit.SelectedValue);
            stock.MaxUnitId = Convert.ToInt32(cboMaxUnit.SelectedValue);
            stock.Discontinue = chbDiscontinue.Checked;
            stock.DefaultUnit = Convert.ToInt32(cboDefault.SelectedValue);


            stock.PurchasePrice = 0;
            stock.SellingPrice = nudSellingPrice.Value;
            stock.StockIcon = GlobalFunction.ConvertImageToBinary(picStock.Image);
            stock.ModifiedDate = DateTime.Now;
            stock.InQty = 0;
            stock.IsStore = chkIsStore.Checked;
            #endregion

            #region Conversion
            
            dsNewSetup.ConversionRow convRow;

            int count = 1;
            foreach (DataGridViewRow row in dgvUnitConversion.Rows)
            {
                convRow = convDT.NewConversionRow();

                //if (string.IsNullOrEmpty(STOCK_ID))
                //{
                //    convRow.ConversionId = row.Cells["colConversionId"].Value.ToString();
                //}

                convRow.UnitId = Convert.ToInt32(row.Cells["colUnitID"].Value);

                if (count == 1)
                {
                    convRow.ParentId = "";
                }
                else
                {
                    convRow.ParentId = dgvUnitConversion.Rows[row.Index - 1].Cells["colUnitID"].Value.ToString();
                }

                convRow.ConvertQty = Convert.ToDecimal(row.Cells[colCQty.Index].Value);
                convRow.RetailPrice = Convert.ToDecimal(row.Cells[colRetailPrice.Index].Value);
                convRow.WholesalePrice = Convert.ToDecimal(row.Cells[colWholesalePrice.Index].Value);
                convRow.PurchasePrice = Convert.ToDecimal(row.Cells[colBuyPrice.Index].Value);

                convRow.InvQty = 0;
                convRow.Serial = count++;

                convDT.AddConversionRow(convRow);
            }
            #endregion

            try
            {
                _stock.Insert(stock, convDT);

                //stockController.Update(stockRow, convDT);
                ClearControl();
                DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DataBind()
        {
            kto_dgvStock.AutoGenerateColumns = false;
            kto_dgvStock.DataSource = _stock.GetStockList(STOCK_ID);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Title = "User Image";
            openFile.Filter = "Images (*.BMP;*.JPG;,*.PNG)|*.BMP;*.JPG;*.PNG|" + "All files (*.*)|*.*";
            DialogResult dr = openFile.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                picStock.Image = Bitmap.FromFile(openFile.FileName);
                picStock.SizeMode = PictureBoxSizeMode.StretchImage;
                picStock.Refresh();
            }
        }

        private void kto_dgvStock_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GlobalFunction.GridView_DataBindingComplete(sender, e);
        }

        private void kto_dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = kto_dgvStock.Columns[kto_dgvStock.CurrentCell.ColumnIndex].Name;
            if (colName == "colEdit")
            {
                STOCK_ID = kto_dgvStock.Rows[e.RowIndex].Cells["colStock_Id"].Value.ToString();
                ControlDataBind();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cboDefault.SelectedIndex == -1) return;

            #region Stock

            stock.StockId = STOCK_ID;
            stock.StockCode = txtCode.Text.Trim();
            stock.StockName = txtName.Text.Trim();
            stock.CategoryId = Convert.ToInt32(cboCategory.SelectedValue);
            stock.SaleCurrencyId = Convert.ToInt32(cboSaleCur.SelectedValue);
            stock.Minqty = numMin.Value;
            stock.Maxqty = numMax.Value;
            stock.MinUnitId = Convert.ToInt32(cboMinUnit.SelectedValue);
            stock.MaxUnitId = Convert.ToInt32(cboMaxUnit.SelectedValue);
            stock.Discontinue = chbDiscontinue.Checked;
            stock.DefaultUnit = Convert.ToInt32(cboDefault.SelectedValue);


            stock.PurchasePrice = nudPurchasePrice.Value;
            stock.SellingPrice = nudSellingPrice.Value;
            
            stock.StockIcon = GlobalFunction.ConvertImageToBinary(picStock.Image);
            stock.ModifiedDate = DateTime.Now;
            stock.InQty = 0;

            #endregion

            #region Conversion
            
            dsNewSetup.ConversionRow convRow;

            int count = 1;
            foreach (DataGridViewRow row in dgvUnitConversion.Rows)
            {
                convRow = convDT.NewConversionRow();

                if (STOCK_ID != null)
                {
                    convRow.ConversionId = row.Cells["colConversionId"].Value.ToString();
                }
                convRow.StockId = STOCK_ID;
                convRow.UnitId = Convert.ToInt32(row.Cells["colUnitID"].Value);

                if (count == 1)
                {
                    convRow.ParentId = "";
                }
                else
                {
                    convRow.ParentId = dgvUnitConversion.Rows[row.Index - 1].Cells["colUnitID"].Value.ToString();
                }

                convRow.ConvertQty = Convert.ToDecimal(row.Cells[colCQty.Index].Value);
                
                convRow.RetailPrice = Convert.ToDecimal(row.Cells[colRetailPrice.Index].Value);
                convRow.WholesalePrice = Convert.ToDecimal(row.Cells[colWholesalePrice.Index].Value);
                convRow.PurchasePrice = Convert.ToDecimal(row.Cells[colBuyPrice.Index].Value);
                convRow.InvQty = 0;
                
                convRow.Serial = count++;

                convDT.AddConversionRow(convRow);
            }
            #endregion

            try
            {
                _stock.Update(stock, convDT);
                ClearControl();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(STOCK_ID))
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure to delete", "Stock Delete", MessageBoxButtons.YesNo))
                {
                    _stock.Delete(STOCK_ID);
                    ClearControl();
                    DataBind();
                }
            }
        }

        private void cboCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (chkSearch.Checked)
            {
                kto_dgvStock.AutoGenerateColumns = false;
                kto_dgvStock.DataSource = _stock.GetStockByCateoryId(Convert.ToInt32(cboCategory.SelectedValue));
            }
        }
    }
}
