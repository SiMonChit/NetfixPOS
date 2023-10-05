
namespace NetfixPOS.NewSetup
{
    partial class StockMaster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvStockMaster = new System.Windows.Forms.DataGridView();
            this.trvCategory = new System.Windows.Forms.TreeView();
            this.colStockId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.colStockCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaxqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinUnitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaxUnitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleCurrencyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.trvCategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 631);
            this.panel1.TabIndex = 0;
            // 
            // dgvStockMaster
            // 
            this.dgvStockMaster.AllowUserToAddRows = false;
            this.dgvStockMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStockId,
            this.colStockIcon,
            this.colStockCode,
            this.colStockName,
            this.colCategoryId,
            this.colMinqty,
            this.colMaxqty,
            this.colMinUnitId,
            this.colMaxUnitId,
            this.colSaleCurrencyId,
            this.colPurchasePrice,
            this.colSellingPrice,
            this.colInQty,
            this.colEdit,
            this.colDel});
            this.dgvStockMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockMaster.Location = new System.Drawing.Point(213, 0);
            this.dgvStockMaster.Name = "dgvStockMaster";
            this.dgvStockMaster.RowHeadersWidth = 50;
            this.dgvStockMaster.RowTemplate.Height = 50;
            this.dgvStockMaster.Size = new System.Drawing.Size(1319, 631);
            this.dgvStockMaster.TabIndex = 1;
            this.dgvStockMaster.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvStockMaster_DataBindingComplete);
            // 
            // trvCategory
            // 
            this.trvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvCategory.Location = new System.Drawing.Point(0, 0);
            this.trvCategory.Name = "trvCategory";
            this.trvCategory.Size = new System.Drawing.Size(211, 629);
            this.trvCategory.TabIndex = 0;
            this.trvCategory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvCategory_AfterSelect);
            // 
            // colStockId
            // 
            this.colStockId.DataPropertyName = "StockId";
            this.colStockId.HeaderText = "StockId";
            this.colStockId.MinimumWidth = 8;
            this.colStockId.Name = "colStockId";
            this.colStockId.Visible = false;
            this.colStockId.Width = 150;
            // 
            // colStockIcon
            // 
            this.colStockIcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStockIcon.DataPropertyName = "StockIcon";
            this.colStockIcon.FillWeight = 80F;
            this.colStockIcon.HeaderText = "Stock Image";
            this.colStockIcon.MinimumWidth = 8;
            this.colStockIcon.Name = "colStockIcon";
            // 
            // colStockCode
            // 
            this.colStockCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStockCode.DataPropertyName = "StockCode";
            this.colStockCode.FillWeight = 60F;
            this.colStockCode.HeaderText = "Stock Code";
            this.colStockCode.MinimumWidth = 8;
            this.colStockCode.Name = "colStockCode";
            // 
            // colStockName
            // 
            this.colStockName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStockName.DataPropertyName = "StockName";
            this.colStockName.HeaderText = "StockName";
            this.colStockName.MinimumWidth = 8;
            this.colStockName.Name = "colStockName";
            // 
            // colCategoryId
            // 
            this.colCategoryId.DataPropertyName = "CategoryId";
            this.colCategoryId.HeaderText = "CategoryId";
            this.colCategoryId.MinimumWidth = 8;
            this.colCategoryId.Name = "colCategoryId";
            this.colCategoryId.Visible = false;
            this.colCategoryId.Width = 150;
            // 
            // colMinqty
            // 
            this.colMinqty.DataPropertyName = "MinQty";
            this.colMinqty.HeaderText = "MinQty";
            this.colMinqty.MinimumWidth = 8;
            this.colMinqty.Name = "colMinqty";
            this.colMinqty.Visible = false;
            this.colMinqty.Width = 150;
            // 
            // colMaxqty
            // 
            this.colMaxqty.DataPropertyName = "MaxQty";
            this.colMaxqty.HeaderText = "Max Qty";
            this.colMaxqty.MinimumWidth = 8;
            this.colMaxqty.Name = "colMaxqty";
            this.colMaxqty.Visible = false;
            this.colMaxqty.Width = 150;
            // 
            // colMinUnitId
            // 
            this.colMinUnitId.DataPropertyName = "MinUnitId";
            this.colMinUnitId.HeaderText = "MinUnitId";
            this.colMinUnitId.MinimumWidth = 8;
            this.colMinUnitId.Name = "colMinUnitId";
            this.colMinUnitId.Visible = false;
            this.colMinUnitId.Width = 150;
            // 
            // colMaxUnitId
            // 
            this.colMaxUnitId.DataPropertyName = "MaxUnitId";
            this.colMaxUnitId.HeaderText = "MaxUnitId";
            this.colMaxUnitId.MinimumWidth = 8;
            this.colMaxUnitId.Name = "colMaxUnitId";
            this.colMaxUnitId.Visible = false;
            this.colMaxUnitId.Width = 150;
            // 
            // colSaleCurrencyId
            // 
            this.colSaleCurrencyId.DataPropertyName = "SaleCurrencyId";
            this.colSaleCurrencyId.HeaderText = "SaleCurrencyId";
            this.colSaleCurrencyId.MinimumWidth = 8;
            this.colSaleCurrencyId.Name = "colSaleCurrencyId";
            this.colSaleCurrencyId.Visible = false;
            this.colSaleCurrencyId.Width = 150;
            // 
            // colPurchasePrice
            // 
            this.colPurchasePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPurchasePrice.DataPropertyName = "PurchasePrice";
            this.colPurchasePrice.HeaderText = "Purchase Price";
            this.colPurchasePrice.MinimumWidth = 8;
            this.colPurchasePrice.Name = "colPurchasePrice";
            // 
            // colSellingPrice
            // 
            this.colSellingPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSellingPrice.DataPropertyName = "SellingPrice";
            this.colSellingPrice.HeaderText = "Selling Price";
            this.colSellingPrice.MinimumWidth = 8;
            this.colSellingPrice.Name = "colSellingPrice";
            // 
            // colInQty
            // 
            this.colInQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colInQty.DataPropertyName = "InQty";
            this.colInQty.HeaderText = "In Qty";
            this.colInQty.MinimumWidth = 8;
            this.colInQty.Name = "colInQty";
            this.colInQty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colInQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colEdit
            // 
            this.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEdit.FillWeight = 50F;
            this.colEdit.HeaderText = "Edit";
            this.colEdit.MinimumWidth = 8;
            this.colEdit.Name = "colEdit";
            this.colEdit.Text = "Edit";
            this.colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDel
            // 
            this.colDel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDel.FillWeight = 50F;
            this.colDel.HeaderText = "Delete";
            this.colDel.MinimumWidth = 8;
            this.colDel.Name = "colDel";
            this.colDel.Text = "Delete";
            this.colDel.UseColumnTextForButtonValue = true;
            // 
            // StockMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 631);
            this.Controls.Add(this.dgvStockMaster);
            this.Controls.Add(this.panel1);
            this.Name = "StockMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockMaster";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvStockMaster;
        private System.Windows.Forms.TreeView trvCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockId;
        private System.Windows.Forms.DataGridViewImageColumn colStockIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaxqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinUnitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaxUnitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleCurrencyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInQty;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDel;
    }
}