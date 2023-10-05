
namespace NetfixPOS.NewSetup
{
    partial class StockItem
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
            this.dgvUnitConversion = new System.Windows.Forms.DataGridView();
            this.colConversionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWholesalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRetailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelItem = new System.Windows.Forms.Panel();
            this.chkIsStore = new System.Windows.Forms.CheckBox();
            this.nudPurchasePrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudSellingPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.picStock = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSaleCur = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConfUnit = new System.Windows.Forms.Button();
            this.cboDefault = new System.Windows.Forms.ComboBox();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.chbDiscontinue = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMinUnit = new System.Windows.Forms.ComboBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.cboMaxUnit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.kto_dgvStock = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.colStock_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurchase_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.chkSearch = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitConversion)).BeginInit();
            this.panelItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchasePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSellingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kto_dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dgvUnitConversion);
            this.panel1.Controls.Add(this.panelItem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1750, 360);
            this.panel1.TabIndex = 0;
            // 
            // dgvUnitConversion
            // 
            this.dgvUnitConversion.AllowUserToAddRows = false;
            this.dgvUnitConversion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvUnitConversion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnitConversion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colConversionId,
            this.colStockId,
            this.colParentId,
            this.colUnitId,
            this.colUnit,
            this.colCQty,
            this.colWholesalePrice,
            this.colRetailPrice,
            this.colSerial,
            this.colInvQty,
            this.colBuyPrice});
            this.dgvUnitConversion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUnitConversion.Location = new System.Drawing.Point(942, 0);
            this.dgvUnitConversion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvUnitConversion.Name = "dgvUnitConversion";
            this.dgvUnitConversion.RowHeadersVisible = false;
            this.dgvUnitConversion.RowHeadersWidth = 62;
            this.dgvUnitConversion.Size = new System.Drawing.Size(808, 360);
            this.dgvUnitConversion.TabIndex = 106;
            // 
            // colConversionId
            // 
            this.colConversionId.DataPropertyName = "ConversionId";
            this.colConversionId.HeaderText = "ConversionId";
            this.colConversionId.MinimumWidth = 8;
            this.colConversionId.Name = "colConversionId";
            this.colConversionId.Visible = false;
            this.colConversionId.Width = 150;
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
            // colParentId
            // 
            this.colParentId.DataPropertyName = "ParentId";
            this.colParentId.HeaderText = "ParentId";
            this.colParentId.MinimumWidth = 8;
            this.colParentId.Name = "colParentId";
            this.colParentId.Visible = false;
            this.colParentId.Width = 150;
            // 
            // colUnitId
            // 
            this.colUnitId.DataPropertyName = "UnitID";
            this.colUnitId.HeaderText = "UnitId";
            this.colUnitId.MinimumWidth = 8;
            this.colUnitId.Name = "colUnitId";
            this.colUnitId.Visible = false;
            this.colUnitId.Width = 150;
            // 
            // colUnit
            // 
            this.colUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUnit.DataPropertyName = "UnitName";
            this.colUnit.HeaderText = "Unit";
            this.colUnit.MinimumWidth = 8;
            this.colUnit.Name = "colUnit";
            // 
            // colCQty
            // 
            this.colCQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCQty.DataPropertyName = "ConvertQty";
            this.colCQty.FillWeight = 80F;
            this.colCQty.HeaderText = "Count Qty";
            this.colCQty.MinimumWidth = 8;
            this.colCQty.Name = "colCQty";
            // 
            // colWholesalePrice
            // 
            this.colWholesalePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colWholesalePrice.DataPropertyName = "WholesalePrice";
            this.colWholesalePrice.HeaderText = "Wholesale Price";
            this.colWholesalePrice.MinimumWidth = 8;
            this.colWholesalePrice.Name = "colWholesalePrice";
            // 
            // colRetailPrice
            // 
            this.colRetailPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRetailPrice.DataPropertyName = "RetailPrice";
            this.colRetailPrice.HeaderText = "RetailPrice";
            this.colRetailPrice.MinimumWidth = 8;
            this.colRetailPrice.Name = "colRetailPrice";
            // 
            // colSerial
            // 
            this.colSerial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSerial.DataPropertyName = "Serial";
            this.colSerial.FillWeight = 80F;
            this.colSerial.HeaderText = "Serial";
            this.colSerial.MinimumWidth = 8;
            this.colSerial.Name = "colSerial";
            this.colSerial.ReadOnly = true;
            this.colSerial.Visible = false;
            // 
            // colInvQty
            // 
            this.colInvQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colInvQty.DataPropertyName = "InvQty";
            this.colInvQty.HeaderText = "InvQty";
            this.colInvQty.MinimumWidth = 8;
            this.colInvQty.Name = "colInvQty";
            this.colInvQty.ReadOnly = true;
            this.colInvQty.Visible = false;
            // 
            // colBuyPrice
            // 
            this.colBuyPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBuyPrice.DataPropertyName = "BuyPrice";
            this.colBuyPrice.HeaderText = "Purchase Price";
            this.colBuyPrice.MinimumWidth = 8;
            this.colBuyPrice.Name = "colBuyPrice";
            // 
            // panelItem
            // 
            this.panelItem.Controls.Add(this.chkSearch);
            this.panelItem.Controls.Add(this.chkIsStore);
            this.panelItem.Controls.Add(this.nudPurchasePrice);
            this.panelItem.Controls.Add(this.label6);
            this.panelItem.Controls.Add(this.nudSellingPrice);
            this.panelItem.Controls.Add(this.label3);
            this.panelItem.Controls.Add(this.btnDelete);
            this.panelItem.Controls.Add(this.btnAdd);
            this.panelItem.Controls.Add(this.btnUpdate);
            this.panelItem.Controls.Add(this.btnSave);
            this.panelItem.Controls.Add(this.picStock);
            this.panelItem.Controls.Add(this.label4);
            this.panelItem.Controls.Add(this.cboSaleCur);
            this.panelItem.Controls.Add(this.label8);
            this.panelItem.Controls.Add(this.btnConfUnit);
            this.panelItem.Controls.Add(this.cboDefault);
            this.panelItem.Controls.Add(this.numMin);
            this.panelItem.Controls.Add(this.cboCategory);
            this.panelItem.Controls.Add(this.chbDiscontinue);
            this.panelItem.Controls.Add(this.label7);
            this.panelItem.Controls.Add(this.label5);
            this.panelItem.Controls.Add(this.cboMinUnit);
            this.panelItem.Controls.Add(this.txtCode);
            this.panelItem.Controls.Add(this.label2);
            this.panelItem.Controls.Add(this.numMax);
            this.panelItem.Controls.Add(this.cboMaxUnit);
            this.panelItem.Controls.Add(this.label1);
            this.panelItem.Controls.Add(this.txtName);
            this.panelItem.Controls.Add(this.label9);
            this.panelItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelItem.Location = new System.Drawing.Point(0, 0);
            this.panelItem.Name = "panelItem";
            this.panelItem.Size = new System.Drawing.Size(942, 360);
            this.panelItem.TabIndex = 89;
            // 
            // chkIsStore
            // 
            this.chkIsStore.AutoSize = true;
            this.chkIsStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chkIsStore.Location = new System.Drawing.Point(191, 8);
            this.chkIsStore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkIsStore.Name = "chkIsStore";
            this.chkIsStore.Size = new System.Drawing.Size(106, 26);
            this.chkIsStore.TabIndex = 114;
            this.chkIsStore.Text = "To Store";
            this.chkIsStore.UseVisualStyleBackColor = false;
            // 
            // nudPurchasePrice
            // 
            this.nudPurchasePrice.DecimalPlaces = 2;
            this.nudPurchasePrice.Location = new System.Drawing.Point(578, 278);
            this.nudPurchasePrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudPurchasePrice.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.nudPurchasePrice.Name = "nudPurchasePrice";
            this.nudPurchasePrice.Size = new System.Drawing.Size(200, 28);
            this.nudPurchasePrice.TabIndex = 112;
            this.nudPurchasePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPurchasePrice.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(436, 279);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 22);
            this.label6.TabIndex = 113;
            this.label6.Text = "Purchase Price";
            // 
            // nudSellingPrice
            // 
            this.nudSellingPrice.DecimalPlaces = 2;
            this.nudSellingPrice.Location = new System.Drawing.Point(578, 246);
            this.nudSellingPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudSellingPrice.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.nudSellingPrice.Name = "nudSellingPrice";
            this.nudSellingPrice.Size = new System.Drawing.Size(200, 28);
            this.nudSellingPrice.TabIndex = 110;
            this.nudSellingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSellingPrice.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(458, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 111;
            this.label3.Text = "Selling Price";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(821, 316);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 35);
            this.btnDelete.TabIndex = 109;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(11, 141);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 31);
            this.btnAdd.TabIndex = 105;
            this.btnAdd.Text = "Add Image";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(700, 316);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 35);
            this.btnUpdate.TabIndex = 108;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(578, 316);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 107;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picStock
            // 
            this.picStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picStock.Location = new System.Drawing.Point(11, 3);
            this.picStock.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picStock.Name = "picStock";
            this.picStock.Size = new System.Drawing.Size(139, 138);
            this.picStock.TabIndex = 104;
            this.picStock.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(448, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 97;
            this.label4.Text = "Sale Currency";
            // 
            // cboSaleCur
            // 
            this.cboSaleCur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSaleCur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSaleCur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSaleCur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboSaleCur.FormattingEnabled = true;
            this.cboSaleCur.Location = new System.Drawing.Point(578, 146);
            this.cboSaleCur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSaleCur.Name = "cboSaleCur";
            this.cboSaleCur.Size = new System.Drawing.Size(200, 28);
            this.cboSaleCur.TabIndex = 92;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(9, 181);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 22);
            this.label8.TabIndex = 103;
            this.label8.Text = "Category";
            // 
            // btnConfUnit
            // 
            this.btnConfUnit.Location = new System.Drawing.Point(578, 77);
            this.btnConfUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfUnit.Name = "btnConfUnit";
            this.btnConfUnit.Size = new System.Drawing.Size(200, 39);
            this.btnConfUnit.TabIndex = 89;
            this.btnConfUnit.Text = "Config Unit";
            this.btnConfUnit.UseVisualStyleBackColor = true;
            this.btnConfUnit.Click += new System.EventHandler(this.btnConfUnit_Click);
            // 
            // cboDefault
            // 
            this.cboDefault.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboDefault.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDefault.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboDefault.FormattingEnabled = true;
            this.cboDefault.Location = new System.Drawing.Point(578, 118);
            this.cboDefault.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDefault.Name = "cboDefault";
            this.cboDefault.Size = new System.Drawing.Size(200, 28);
            this.cboDefault.TabIndex = 91;
            // 
            // numMin
            // 
            this.numMin.DecimalPlaces = 2;
            this.numMin.Location = new System.Drawing.Point(578, 212);
            this.numMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numMin.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(200, 28);
            this.numMin.TabIndex = 94;
            this.numMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numMin.ThousandsSeparator = true;
            // 
            // cboCategory
            // 
            this.cboCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(13, 213);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(248, 28);
            this.cboCategory.TabIndex = 102;
            this.cboCategory.SelectionChangeCommitted += new System.EventHandler(this.cboCategory_SelectionChangeCommitted);
            // 
            // chbDiscontinue
            // 
            this.chbDiscontinue.AutoSize = true;
            this.chbDiscontinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chbDiscontinue.Location = new System.Drawing.Point(191, 43);
            this.chbDiscontinue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbDiscontinue.Name = "chbDiscontinue";
            this.chbDiscontinue.Size = new System.Drawing.Size(130, 26);
            this.chbDiscontinue.TabIndex = 95;
            this.chbDiscontinue.Text = "Discontinue";
            this.chbDiscontinue.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(469, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 22);
            this.label7.TabIndex = 96;
            this.label7.Text = "Default Unit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(495, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 22);
            this.label5.TabIndex = 98;
            this.label5.Text = "Min Qty";
            // 
            // cboMinUnit
            // 
            this.cboMinUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMinUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMinUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMinUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboMinUnit.FormattingEnabled = true;
            this.cboMinUnit.Location = new System.Drawing.Point(787, 213);
            this.cboMinUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMinUnit.Name = "cboMinUnit";
            this.cboMinUnit.Size = new System.Drawing.Size(121, 28);
            this.cboMinUnit.TabIndex = 101;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(580, 5);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(243, 28);
            this.txtCode.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(465, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 90;
            this.label2.Text = "Stock Name";
            // 
            // numMax
            // 
            this.numMax.DecimalPlaces = 2;
            this.numMax.Location = new System.Drawing.Point(578, 180);
            this.numMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numMax.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(200, 28);
            this.numMax.TabIndex = 93;
            this.numMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numMax.ThousandsSeparator = true;
            // 
            // cboMaxUnit
            // 
            this.cboMaxUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMaxUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMaxUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaxUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboMaxUnit.FormattingEnabled = true;
            this.cboMaxUnit.Location = new System.Drawing.Point(787, 182);
            this.cboMaxUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMaxUnit.Name = "cboMaxUnit";
            this.cboMaxUnit.Size = new System.Drawing.Size(121, 28);
            this.cboMaxUnit.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(468, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 88;
            this.label1.Text = "Stock Code";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(580, 39);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(243, 28);
            this.txtName.TabIndex = 87;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(490, 183);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 22);
            this.label9.TabIndex = 99;
            this.label9.Text = "Max Qty";
            // 
            // kto_dgvStock
            // 
            this.kto_dgvStock.AllowUserToAddRows = false;
            this.kto_dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kto_dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStock_Id,
            this.colCategoryId,
            this.colCategoryName,
            this.colStock_Code,
            this.colStock_Name,
            this.colSellingPrice,
            this.colPurchase_Price,
            this.colEdit});
            this.kto_dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kto_dgvStock.Location = new System.Drawing.Point(0, 360);
            this.kto_dgvStock.Name = "kto_dgvStock";
            this.kto_dgvStock.RowHeadersWidth = 50;
            this.kto_dgvStock.RowTemplate.Height = 28;
            this.kto_dgvStock.Size = new System.Drawing.Size(1750, 314);
            this.kto_dgvStock.TabIndex = 1;
            this.kto_dgvStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kto_dgvStock_CellContentClick);
            this.kto_dgvStock.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.kto_dgvStock_DataBindingComplete);
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
            // colCategoryId
            // 
            this.colCategoryId.DataPropertyName = "CategoryId";
            this.colCategoryId.HeaderText = "CategoryId";
            this.colCategoryId.MinimumWidth = 8;
            this.colCategoryId.Name = "colCategoryId";
            this.colCategoryId.Visible = false;
            this.colCategoryId.Width = 150;
            // 
            // colCategoryName
            // 
            this.colCategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCategoryName.DataPropertyName = "CategoryName";
            this.colCategoryName.FillWeight = 70F;
            this.colCategoryName.HeaderText = "Category";
            this.colCategoryName.MinimumWidth = 8;
            this.colCategoryName.Name = "colCategoryName";
            // 
            // colStock_Code
            // 
            this.colStock_Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStock_Code.DataPropertyName = "StockCode";
            this.colStock_Code.FillWeight = 50F;
            this.colStock_Code.HeaderText = "Stock Code";
            this.colStock_Code.MinimumWidth = 8;
            this.colStock_Code.Name = "colStock_Code";
            // 
            // colStock_Name
            // 
            this.colStock_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStock_Name.DataPropertyName = "StockName";
            this.colStock_Name.HeaderText = "Stock Name";
            this.colStock_Name.MinimumWidth = 8;
            this.colStock_Name.Name = "colStock_Name";
            // 
            // colSellingPrice
            // 
            this.colSellingPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSellingPrice.DataPropertyName = "SellingPrice";
            this.colSellingPrice.HeaderText = "Selling Price";
            this.colSellingPrice.MinimumWidth = 8;
            this.colSellingPrice.Name = "colSellingPrice";
            // 
            // colPurchase_Price
            // 
            this.colPurchase_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPurchase_Price.DataPropertyName = "PurchasePrice";
            this.colPurchase_Price.FillWeight = 80F;
            this.colPurchase_Price.HeaderText = "PurchasePrice";
            this.colPurchase_Price.MinimumWidth = 8;
            this.colPurchase_Price.Name = "colPurchase_Price";
            // 
            // colEdit
            // 
            this.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEdit.FillWeight = 20F;
            this.colEdit.HeaderText = "Edit";
            this.colEdit.MinimumWidth = 8;
            this.colEdit.Name = "colEdit";
            this.colEdit.Text = "Edit";
            this.colEdit.UseColumnTextForButtonValue = true;
            // 
            // chkSearch
            // 
            this.chkSearch.AutoSize = true;
            this.chkSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chkSearch.Location = new System.Drawing.Point(269, 215);
            this.chkSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkSearch.Name = "chkSearch";
            this.chkSearch.Size = new System.Drawing.Size(93, 26);
            this.chkSearch.TabIndex = 115;
            this.chkSearch.Text = "Search";
            this.chkSearch.UseVisualStyleBackColor = false;
            // 
            // StockItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1750, 674);
            this.Controls.Add(this.kto_dgvStock);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StockItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitConversion)).EndInit();
            this.panelItem.ResumeLayout(false);
            this.panelItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchasePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSellingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kto_dgvStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox picStock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ComboBox cboMinUnit;
        private System.Windows.Forms.ComboBox cboMaxUnit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.ComboBox cboSaleCur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfUnit;
        private System.Windows.Forms.CheckBox chbDiscontinue;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboDefault;
        private System.Windows.Forms.DataGridView dgvUnitConversion;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConversionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWholesalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRetailPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyPrice;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kto_dgvStock;
        private System.Windows.Forms.NumericUpDown nudSellingPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPurchasePrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurchase_Price;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.CheckBox chkIsStore;
        private System.Windows.Forms.CheckBox chkSearch;
    }
}