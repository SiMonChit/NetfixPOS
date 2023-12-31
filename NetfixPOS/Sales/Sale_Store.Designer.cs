﻿
namespace NetfixPOS.Sales
{
    partial class Sale_Store
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
            this.cboWaiter = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtServiceAmt = new System.Windows.Forms.TextBox();
            this.txtSerPercent = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.btnPendding = new System.Windows.Forms.Button();
            this.txtDeliveryFee = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkFOC = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTableOrRoom = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboSalePerson = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboSaleType = new System.Windows.Forms.ComboBox();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trvCategory = new System.Windows.Forms.TreeView();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.colStockId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBalanceAmount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNetAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.dgvSaleItem = new System.Windows.Forms.DataGridView();
            this.colSaleDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConvensionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleStockId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleStockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsFOC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cboWaiter);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtServiceAmt);
            this.panel1.Controls.Add(this.txtSerPercent);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cboCustomer);
            this.panel1.Controls.Add(this.btnPendding);
            this.panel1.Controls.Add(this.txtDeliveryFee);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.chkFOC);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtTableOrRoom);
            this.panel1.Controls.Add(this.txtDiscount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cboSalePerson);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtRemark);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dtpInvoiceDate);
            this.panel1.Controls.Add(this.txtInvoiceNo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1759, 163);
            this.panel1.TabIndex = 1;
            // 
            // cboWaiter
            // 
            this.cboWaiter.FormattingEnabled = true;
            this.cboWaiter.Location = new System.Drawing.Point(836, 123);
            this.cboWaiter.Name = "cboWaiter";
            this.cboWaiter.Size = new System.Drawing.Size(237, 28);
            this.cboWaiter.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(755, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "Waiter";
            // 
            // txtServiceAmt
            // 
            this.txtServiceAmt.Location = new System.Drawing.Point(1309, 89);
            this.txtServiceAmt.Name = "txtServiceAmt";
            this.txtServiceAmt.ReadOnly = true;
            this.txtServiceAmt.Size = new System.Drawing.Size(121, 26);
            this.txtServiceAmt.TabIndex = 29;
            this.txtServiceAmt.Text = "0";
            // 
            // txtSerPercent
            // 
            this.txtSerPercent.Location = new System.Drawing.Point(1246, 89);
            this.txtSerPercent.Name = "txtSerPercent";
            this.txtSerPercent.ReadOnly = true;
            this.txtSerPercent.Size = new System.Drawing.Size(57, 26);
            this.txtSerPercent.TabIndex = 28;
            this.txtSerPercent.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1154, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "ServiceTax";
            // 
            // cboCustomer
            // 
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(172, 126);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(237, 28);
            this.cboCustomer.TabIndex = 26;
            // 
            // btnPendding
            // 
            this.btnPendding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPendding.Location = new System.Drawing.Point(1659, 14);
            this.btnPendding.Name = "btnPendding";
            this.btnPendding.Size = new System.Drawing.Size(89, 41);
            this.btnPendding.TabIndex = 25;
            this.btnPendding.Text = "Pending";
            this.btnPendding.UseVisualStyleBackColor = false;
            // 
            // txtDeliveryFee
            // 
            this.txtDeliveryFee.Location = new System.Drawing.Point(1246, 50);
            this.txtDeliveryFee.Name = "txtDeliveryFee";
            this.txtDeliveryFee.Size = new System.Drawing.Size(184, 26);
            this.txtDeliveryFee.TabIndex = 24;
            this.txtDeliveryFee.Text = "0";
            this.txtDeliveryFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1154, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "DeliveryFee";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1659, 112);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(89, 41);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1659, 64);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 41);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // chkFOC
            // 
            this.chkFOC.AutoSize = true;
            this.chkFOC.Location = new System.Drawing.Point(1479, 14);
            this.chkFOC.Name = "chkFOC";
            this.chkFOC.Size = new System.Drawing.Size(68, 24);
            this.chkFOC.TabIndex = 22;
            this.chkFOC.Text = "FOC";
            this.chkFOC.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(460, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Table / Room No";
            // 
            // txtTableOrRoom
            // 
            this.txtTableOrRoom.Location = new System.Drawing.Point(464, 123);
            this.txtTableOrRoom.Name = "txtTableOrRoom";
            this.txtTableOrRoom.ReadOnly = true;
            this.txtTableOrRoom.Size = new System.Drawing.Size(233, 26);
            this.txtTableOrRoom.TabIndex = 20;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(1246, 14);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(184, 26);
            this.txtDiscount.TabIndex = 13;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1154, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Discount";
            // 
            // cboSalePerson
            // 
            this.cboSalePerson.FormattingEnabled = true;
            this.cboSalePerson.Location = new System.Drawing.Point(172, 89);
            this.cboSalePerson.Name = "cboSalePerson";
            this.cboSalePerson.Size = new System.Drawing.Size(237, 28);
            this.cboSalePerson.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(755, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Remark";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(836, 14);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(278, 98);
            this.txtRemark.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboSaleType);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(438, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 72);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sale Type";
            // 
            // cboSaleType
            // 
            this.cboSaleType.FormattingEnabled = true;
            this.cboSaleType.Location = new System.Drawing.Point(26, 28);
            this.cboSaleType.Name = "cboSaleType";
            this.cboSaleType.Size = new System.Drawing.Size(233, 28);
            this.cboSaleType.TabIndex = 0;
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.Enabled = false;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(172, 51);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(237, 26);
            this.dtpInvoiceDate.TabIndex = 7;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(172, 14);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.ReadOnly = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(237, 26);
            this.txtInvoiceNo.TabIndex = 4;
            this.txtInvoiceNo.Text = "Auto generate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sale Person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Invoice Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice No";
            // 
            // trvCategory
            // 
            this.trvCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvCategory.Location = new System.Drawing.Point(0, 163);
            this.trvCategory.Name = "trvCategory";
            this.trvCategory.Size = new System.Drawing.Size(203, 515);
            this.trvCategory.TabIndex = 2;
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStockId,
            this.colStockName,
            this.colSellingPrice});
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvStock.Location = new System.Drawing.Point(203, 163);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersWidth = 40;
            this.dgvStock.RowTemplate.Height = 28;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(404, 515);
            this.dgvStock.TabIndex = 3;
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
            this.colStockName.ReadOnly = true;
            // 
            // colSellingPrice
            // 
            this.colSellingPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSellingPrice.DataPropertyName = "SellingPrice";
            this.colSellingPrice.FillWeight = 70F;
            this.colSellingPrice.HeaderText = "Selling Price";
            this.colSellingPrice.MinimumWidth = 8;
            this.colSellingPrice.Name = "colSellingPrice";
            this.colSellingPrice.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtBalanceAmount);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtPaidAmount);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtNetAmount);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtTotalAmount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(607, 608);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1152, 70);
            this.panel2.TabIndex = 4;
            // 
            // txtBalanceAmount
            // 
            this.txtBalanceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalanceAmount.Location = new System.Drawing.Point(985, 21);
            this.txtBalanceAmount.Name = "txtBalanceAmount";
            this.txtBalanceAmount.ReadOnly = true;
            this.txtBalanceAmount.Size = new System.Drawing.Size(157, 26);
            this.txtBalanceAmount.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(852, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 20);
            this.label14.TabIndex = 22;
            this.label14.Text = "Balance Amount";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidAmount.Location = new System.Drawing.Point(681, 21);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(157, 26);
            this.txtPaidAmount.TabIndex = 21;
            this.txtPaidAmount.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(577, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Paid Amount";
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetAmount.Location = new System.Drawing.Point(410, 21);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.ReadOnly = true;
            this.txtNetAmount.Size = new System.Drawing.Size(157, 26);
            this.txtNetAmount.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Net Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Total Amount";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(133, 21);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(157, 26);
            this.txtTotalAmount.TabIndex = 19;
            // 
            // dgvSaleItem
            // 
            this.dgvSaleItem.AllowUserToAddRows = false;
            this.dgvSaleItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSaleItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSaleDetailId,
            this.colCategoryID,
            this.colConvensionId,
            this.colSaleStockId,
            this.colSaleStockName,
            this.colSerial,
            this.colUnitName,
            this.colQty,
            this.colSalePrice,
            this.colDiscount,
            this.colAmount,
            this.colIsFOC,
            this.colRemove});
            this.dgvSaleItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvSaleItem.Location = new System.Drawing.Point(607, 163);
            this.dgvSaleItem.Name = "dgvSaleItem";
            this.dgvSaleItem.RowHeadersWidth = 45;
            this.dgvSaleItem.RowTemplate.Height = 28;
            this.dgvSaleItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSaleItem.Size = new System.Drawing.Size(941, 445);
            this.dgvSaleItem.TabIndex = 5;
            // 
            // colSaleDetailId
            // 
            this.colSaleDetailId.DataPropertyName = "SaleDetailId";
            this.colSaleDetailId.HeaderText = "SaleDetailId";
            this.colSaleDetailId.MinimumWidth = 8;
            this.colSaleDetailId.Name = "colSaleDetailId";
            this.colSaleDetailId.Visible = false;
            this.colSaleDetailId.Width = 150;
            // 
            // colCategoryID
            // 
            this.colCategoryID.DataPropertyName = "CategoryID";
            this.colCategoryID.HeaderText = "CategoryID";
            this.colCategoryID.MinimumWidth = 8;
            this.colCategoryID.Name = "colCategoryID";
            this.colCategoryID.Visible = false;
            this.colCategoryID.Width = 150;
            // 
            // colConvensionId
            // 
            this.colConvensionId.DataPropertyName = "ConvensionId";
            this.colConvensionId.HeaderText = "ConvensionId";
            this.colConvensionId.MinimumWidth = 8;
            this.colConvensionId.Name = "colConvensionId";
            this.colConvensionId.Visible = false;
            this.colConvensionId.Width = 150;
            // 
            // colSaleStockId
            // 
            this.colSaleStockId.DataPropertyName = "StockId";
            this.colSaleStockId.HeaderText = "StockId";
            this.colSaleStockId.MinimumWidth = 8;
            this.colSaleStockId.Name = "colSaleStockId";
            this.colSaleStockId.Visible = false;
            this.colSaleStockId.Width = 150;
            // 
            // colSaleStockName
            // 
            this.colSaleStockName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSaleStockName.DataPropertyName = "StockName";
            this.colSaleStockName.HeaderText = "StockName";
            this.colSaleStockName.MinimumWidth = 8;
            this.colSaleStockName.Name = "colSaleStockName";
            this.colSaleStockName.ReadOnly = true;
            // 
            // colSerial
            // 
            this.colSerial.DataPropertyName = "Serial";
            this.colSerial.HeaderText = "Serial";
            this.colSerial.MinimumWidth = 8;
            this.colSerial.Name = "colSerial";
            this.colSerial.Visible = false;
            this.colSerial.Width = 150;
            // 
            // colUnitName
            // 
            this.colUnitName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUnitName.FillWeight = 70F;
            this.colUnitName.HeaderText = "Unit";
            this.colUnitName.MinimumWidth = 8;
            this.colUnitName.Name = "colUnitName";
            this.colUnitName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colUnitName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colQty
            // 
            this.colQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colQty.DataPropertyName = "Qty";
            this.colQty.FillWeight = 50F;
            this.colQty.HeaderText = "Qty";
            this.colQty.MinimumWidth = 8;
            this.colQty.Name = "colQty";
            // 
            // colSalePrice
            // 
            this.colSalePrice.DataPropertyName = "SalePrice";
            this.colSalePrice.HeaderText = "SalePrice";
            this.colSalePrice.MinimumWidth = 8;
            this.colSalePrice.Name = "colSalePrice";
            this.colSalePrice.Visible = false;
            this.colSalePrice.Width = 150;
            // 
            // colDiscount
            // 
            this.colDiscount.DataPropertyName = "Discount";
            this.colDiscount.HeaderText = "Discount";
            this.colDiscount.MinimumWidth = 8;
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Visible = false;
            this.colDiscount.Width = 150;
            // 
            // colAmount
            // 
            this.colAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.FillWeight = 70F;
            this.colAmount.HeaderText = "Amount";
            this.colAmount.MinimumWidth = 8;
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colIsFOC
            // 
            this.colIsFOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colIsFOC.DataPropertyName = "IsFOC";
            this.colIsFOC.FalseValue = "0";
            this.colIsFOC.FillWeight = 50F;
            this.colIsFOC.HeaderText = "FOC";
            this.colIsFOC.MinimumWidth = 8;
            this.colIsFOC.Name = "colIsFOC";
            this.colIsFOC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsFOC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colRemove
            // 
            this.colRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRemove.FillWeight = 45F;
            this.colRemove.HeaderText = "Remove";
            this.colRemove.MinimumWidth = 8;
            this.colRemove.Name = "colRemove";
            this.colRemove.Text = "Remove";
            this.colRemove.UseColumnTextForButtonValue = true;
            // 
            // Sale_Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1759, 678);
            this.Controls.Add(this.dgvSaleItem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.trvCategory);
            this.Controls.Add(this.panel1);
            this.Name = "Sale_Store";
            this.Text = "Sale_Store";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboWaiter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtServiceAmt;
        private System.Windows.Forms.TextBox txtSerPercent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Button btnPendding;
        private System.Windows.Forms.TextBox txtDeliveryFee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkFOC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTableOrRoom;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboSalePerson;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboSaleType;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView trvCategory;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellingPrice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBalanceAmount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNetAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.DataGridView dgvSaleItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConvensionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleStockId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleStockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerial;
        private System.Windows.Forms.DataGridViewComboBoxColumn colUnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsFOC;
        private System.Windows.Forms.DataGridViewButtonColumn colRemove;
    }
}