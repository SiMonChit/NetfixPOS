
namespace NetfixPOS.Purchase
{
    partial class frm_Purchase
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnImport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnNew = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonDateTimePicker1 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.trvCategory = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.colStock_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurchase_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_PurchaseItem = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.colPurchaseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPur_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PurchaseItem)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnDelete);
            this.kryptonPanel1.Controls.Add(this.btnImport);
            this.kryptonPanel1.Controls.Add(this.btnUpdate);
            this.kryptonPanel1.Controls.Add(this.btnSave);
            this.kryptonPanel1.Controls.Add(this.btnNew);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel1.Location = new System.Drawing.Point(1478, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderSecondary;
            this.kryptonPanel1.Size = new System.Drawing.Size(164, 623);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnDelete.Location = new System.Drawing.Point(28, 145);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 35);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Values.Text = "Delete";
            // 
            // btnImport
            // 
            this.btnImport.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnImport.Location = new System.Drawing.Point(28, 228);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(111, 35);
            this.btnImport.TabIndex = 0;
            this.btnImport.Values.Text = "Import";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnUpdate.Location = new System.Drawing.Point(28, 103);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 35);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Values.Text = "Update";
            // 
            // btnSave
            // 
            this.btnSave.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnSave.Location = new System.Drawing.Point(28, 62);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 35);
            this.btnSave.TabIndex = 3;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnNew.Location = new System.Drawing.Point(28, 22);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(111, 35);
            this.btnNew.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNew.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Gray;
            this.btnNew.TabIndex = 2;
            this.btnNew.Values.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Controls.Add(this.kryptonDateTimePicker1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.TabDock;
            this.kryptonPanel2.Size = new System.Drawing.Size(1478, 74);
            this.kryptonPanel2.TabIndex = 4;
            // 
            // kryptonDateTimePicker1
            // 
            this.kryptonDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kryptonDateTimePicker1.Location = new System.Drawing.Point(1269, 22);
            this.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            this.kryptonDateTimePicker1.Size = new System.Drawing.Size(154, 30);
            this.kryptonDateTimePicker1.TabIndex = 0;
            // 
            // trvCategory
            // 
            this.trvCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvCategory.Location = new System.Drawing.Point(0, 74);
            this.trvCategory.Name = "trvCategory";
            this.trvCategory.Padding = new System.Windows.Forms.Padding(2);
            this.trvCategory.Size = new System.Drawing.Size(166, 549);
            this.trvCategory.TabIndex = 5;
            this.trvCategory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvCategory_AfterSelect);
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStock_Id,
            this.colStock_Name,
            this.colPurchase_Price});
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvStock.Location = new System.Drawing.Point(166, 74);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.RowHeadersWidth = 62;
            this.dgvStock.RowTemplate.Height = 28;
            this.dgvStock.Size = new System.Drawing.Size(256, 549);
            this.dgvStock.TabIndex = 6;
            this.dgvStock.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellDoubleClick);
            // 
            // colStock_Id
            // 
            this.colStock_Id.DataPropertyName = "StockId";
            this.colStock_Id.HeaderText = "StockId";
            this.colStock_Id.MinimumWidth = 8;
            this.colStock_Id.Name = "colStock_Id";
            this.colStock_Id.Visible = false;
            this.colStock_Id.Width = 150;
            // 
            // colStock_Name
            // 
            this.colStock_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStock_Name.DataPropertyName = "StockName";
            this.colStock_Name.HeaderText = "StockName";
            this.colStock_Name.MinimumWidth = 8;
            this.colStock_Name.Name = "colStock_Name";
            this.colStock_Name.ReadOnly = true;
            // 
            // colPurchase_Price
            // 
            this.colPurchase_Price.DataPropertyName = "PurchasePrice";
            this.colPurchase_Price.HeaderText = "PurchasePrice";
            this.colPurchase_Price.MinimumWidth = 8;
            this.colPurchase_Price.Name = "colPurchase_Price";
            this.colPurchase_Price.Visible = false;
            this.colPurchase_Price.Width = 150;
            // 
            // dgv_PurchaseItem
            // 
            this.dgv_PurchaseItem.AllowUserToAddRows = false;
            this.dgv_PurchaseItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PurchaseItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPurchaseId,
            this.colStockId,
            this.colStockName,
            this.colPurchasePrice,
            this.colQty,
            this.colAmount,
            this.colPur_Date,
            this.colUserID,
            this.colIsActive,
            this.colRemove});
            this.dgv_PurchaseItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_PurchaseItem.Location = new System.Drawing.Point(422, 74);
            this.dgv_PurchaseItem.Name = "dgv_PurchaseItem";
            this.dgv_PurchaseItem.RowHeadersWidth = 62;
            this.dgv_PurchaseItem.RowTemplate.Height = 28;
            this.dgv_PurchaseItem.Size = new System.Drawing.Size(1056, 549);
            this.dgv_PurchaseItem.TabIndex = 7;
            this.dgv_PurchaseItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PurchaseItem_CellContentClick);
            this.dgv_PurchaseItem.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PurchaseItem_CellValidated);
            this.dgv_PurchaseItem.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_PurchaseItem_DataBindingComplete);
            // 
            // colPurchaseId
            // 
            this.colPurchaseId.DataPropertyName = "PurchaseId";
            this.colPurchaseId.HeaderText = "PurchaseId";
            this.colPurchaseId.MinimumWidth = 8;
            this.colPurchaseId.Name = "colPurchaseId";
            this.colPurchaseId.Visible = false;
            this.colPurchaseId.Width = 150;
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
            // colStockName
            // 
            this.colStockName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStockName.DataPropertyName = "StockName";
            this.colStockName.HeaderText = "Stock Name";
            this.colStockName.MinimumWidth = 8;
            this.colStockName.Name = "colStockName";
            this.colStockName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colPurchasePrice
            // 
            this.colPurchasePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPurchasePrice.DataPropertyName = "PurchasePrice";
            this.colPurchasePrice.HeaderText = "PurchasePrice";
            this.colPurchasePrice.MinimumWidth = 8;
            this.colPurchasePrice.Name = "colPurchasePrice";
            this.colPurchasePrice.ReadOnly = true;
            this.colPurchasePrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colQty
            // 
            this.colQty.DataPropertyName = "Qty";
            this.colQty.HeaderText = "Qty";
            this.colQty.MinimumWidth = 8;
            this.colQty.Name = "colQty";
            this.colQty.Width = 150;
            // 
            // colAmount
            // 
            this.colAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "Amount";
            this.colAmount.MinimumWidth = 8;
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colPur_Date
            // 
            this.colPur_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPur_Date.DataPropertyName = "Pur_Date";
            this.colPur_Date.HeaderText = "Date";
            this.colPur_Date.MinimumWidth = 8;
            this.colPur_Date.Name = "colPur_Date";
            this.colPur_Date.ReadOnly = true;
            // 
            // colUserID
            // 
            this.colUserID.DataPropertyName = "UserID";
            this.colUserID.HeaderText = "UserID";
            this.colUserID.MinimumWidth = 8;
            this.colUserID.Name = "colUserID";
            this.colUserID.Visible = false;
            this.colUserID.Width = 150;
            // 
            // colIsActive
            // 
            this.colIsActive.DataPropertyName = "IsActive";
            this.colIsActive.HeaderText = "IsActive";
            this.colIsActive.MinimumWidth = 8;
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = false;
            this.colIsActive.Width = 150;
            // 
            // colRemove
            // 
            this.colRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRemove.FillWeight = 50F;
            this.colRemove.HeaderText = "Remove";
            this.colRemove.MinimumWidth = 8;
            this.colRemove.Name = "colRemove";
            this.colRemove.Text = "Remove";
            this.colRemove.UseColumnTextForButtonValue = true;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel1.Location = new System.Drawing.Point(642, 14);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(192, 43);
            this.kryptonLabel1.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "အဝယ်စာရင်း";
            // 
            // frm_Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1642, 623);
            this.Controls.Add(this.dgv_PurchaseItem);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.trvCategory);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "frm_Purchase";
            this.Text = "Purchase";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PurchaseItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTreeView trvCategory;
        private System.Windows.Forms.DataGridView dgvStock;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_PurchaseItem;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnImport;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNew;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurchase_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurchaseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPur_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsActive;
        private System.Windows.Forms.DataGridViewButtonColumn colRemove;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}