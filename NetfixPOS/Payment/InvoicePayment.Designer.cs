
namespace NetfixPOS.Payment
{
    partial class InvoicePayment
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboPrintType = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkFOC = new System.Windows.Forms.CheckBox();
            this.txtServiceAmt = new System.Windows.Forms.TextBox();
            this.txtSerPercent = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDeliveryFee = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBalanceAmount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNetAmount = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPaidFrom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTableOrRoom = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboSaleType = new System.Windows.Forms.ComboBox();
            this.txtPaymentNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSaleItem = new System.Windows.Forms.DataGridView();
            this.colSaleDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsFOC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboPrinter = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItem)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.chkFOC);
            this.panel1.Controls.Add(this.txtServiceAmt);
            this.panel1.Controls.Add(this.txtSerPercent);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtDeliveryFee);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtDiscount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtBalanceAmount);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtNetAmount);
            this.panel1.Controls.Add(this.txtTotalAmount);
            this.panel1.Controls.Add(this.txtPaidAmount);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(959, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 698);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboPrintType);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(53, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 72);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Print Type";
            // 
            // cboPrintType
            // 
            this.cboPrintType.FormattingEnabled = true;
            this.cboPrintType.Items.AddRange(new object[] {
            "Slip",
            "A5 Voucher",
            "A4 Voucher"});
            this.cboPrintType.Location = new System.Drawing.Point(26, 28);
            this.cboPrintType.Name = "cboPrintType";
            this.cboPrintType.Size = new System.Drawing.Size(233, 28);
            this.cboPrintType.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(244, 571);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(89, 41);
            this.btnPrint.TabIndex = 41;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(149, 571);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 41);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkFOC
            // 
            this.chkFOC.AutoSize = true;
            this.chkFOC.Location = new System.Drawing.Point(149, 291);
            this.chkFOC.Name = "chkFOC";
            this.chkFOC.Size = new System.Drawing.Size(68, 24);
            this.chkFOC.TabIndex = 39;
            this.chkFOC.Text = "FOC";
            this.chkFOC.UseVisualStyleBackColor = true;
            // 
            // txtServiceAmt
            // 
            this.txtServiceAmt.Location = new System.Drawing.Point(212, 98);
            this.txtServiceAmt.Name = "txtServiceAmt";
            this.txtServiceAmt.ReadOnly = true;
            this.txtServiceAmt.Size = new System.Drawing.Size(121, 26);
            this.txtServiceAmt.TabIndex = 38;
            this.txtServiceAmt.Text = "0";
            // 
            // txtSerPercent
            // 
            this.txtSerPercent.Location = new System.Drawing.Point(149, 98);
            this.txtSerPercent.Name = "txtSerPercent";
            this.txtSerPercent.ReadOnly = true;
            this.txtSerPercent.Size = new System.Drawing.Size(57, 26);
            this.txtSerPercent.TabIndex = 37;
            this.txtSerPercent.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "ServiceTax";
            // 
            // txtDeliveryFee
            // 
            this.txtDeliveryFee.Location = new System.Drawing.Point(149, 59);
            this.txtDeliveryFee.Name = "txtDeliveryFee";
            this.txtDeliveryFee.Size = new System.Drawing.Size(184, 26);
            this.txtDeliveryFee.TabIndex = 35;
            this.txtDeliveryFee.Text = "0";
            this.txtDeliveryFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "DeliveryFee";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(149, 23);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(184, 26);
            this.txtDiscount.TabIndex = 33;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Discount";
            // 
            // txtBalanceAmount
            // 
            this.txtBalanceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalanceAmount.Location = new System.Drawing.Point(149, 247);
            this.txtBalanceAmount.Name = "txtBalanceAmount";
            this.txtBalanceAmount.ReadOnly = true;
            this.txtBalanceAmount.Size = new System.Drawing.Size(184, 26);
            this.txtBalanceAmount.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 252);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "Balance Amount";
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetAmount.Location = new System.Drawing.Point(149, 171);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.ReadOnly = true;
            this.txtNetAmount.Size = new System.Drawing.Size(184, 26);
            this.txtNetAmount.TabIndex = 25;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(149, 139);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(184, 26);
            this.txtTotalAmount.TabIndex = 27;
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidAmount.Location = new System.Drawing.Point(149, 215);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(184, 26);
            this.txtPaidAmount.TabIndex = 29;
            this.txtPaidAmount.Leave += new System.EventHandler(this.txtPaidAmount_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Paid Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Total Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Net Amount";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtPaidFrom);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtTableOrRoom);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.txtPaymentNo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 141);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Paid From";
            // 
            // txtPaidFrom
            // 
            this.txtPaidFrom.Location = new System.Drawing.Point(167, 95);
            this.txtPaidFrom.Name = "txtPaidFrom";
            this.txtPaidFrom.Size = new System.Drawing.Size(233, 26);
            this.txtPaidFrom.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Table / Room No";
            // 
            // txtTableOrRoom
            // 
            this.txtTableOrRoom.Location = new System.Drawing.Point(167, 53);
            this.txtTableOrRoom.Name = "txtTableOrRoom";
            this.txtTableOrRoom.ReadOnly = true;
            this.txtTableOrRoom.Size = new System.Drawing.Size(233, 26);
            this.txtTableOrRoom.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboSaleType);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(463, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 72);
            this.groupBox1.TabIndex = 9;
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
            // txtPaymentNo
            // 
            this.txtPaymentNo.Location = new System.Drawing.Point(167, 20);
            this.txtPaymentNo.Name = "txtPaymentNo";
            this.txtPaymentNo.ReadOnly = true;
            this.txtPaymentNo.Size = new System.Drawing.Size(233, 26);
            this.txtPaymentNo.TabIndex = 6;
            this.txtPaymentNo.Text = "Auto generate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Payment No";
            // 
            // dgvSaleItem
            // 
            this.dgvSaleItem.AllowUserToAddRows = false;
            this.dgvSaleItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSaleDetailId,
            this.colStockId,
            this.colStockName,
            this.colQty,
            this.colAmount,
            this.colIsFOC});
            this.dgvSaleItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSaleItem.Location = new System.Drawing.Point(0, 141);
            this.dgvSaleItem.Name = "dgvSaleItem";
            this.dgvSaleItem.RowHeadersWidth = 50;
            this.dgvSaleItem.RowTemplate.Height = 28;
            this.dgvSaleItem.Size = new System.Drawing.Size(959, 557);
            this.dgvSaleItem.TabIndex = 2;
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
            this.colStockName.HeaderText = "StockName";
            this.colStockName.MinimumWidth = 8;
            this.colStockName.Name = "colStockName";
            this.colStockName.ReadOnly = true;
            // 
            // colQty
            // 
            this.colQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colQty.DataPropertyName = "Qty";
            this.colQty.HeaderText = "Qty";
            this.colQty.MinimumWidth = 8;
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
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
            // colIsFOC
            // 
            this.colIsFOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colIsFOC.DataPropertyName = "IsFOC";
            this.colIsFOC.FillWeight = 50F;
            this.colIsFOC.HeaderText = "FOC";
            this.colIsFOC.MinimumWidth = 8;
            this.colIsFOC.Name = "colIsFOC";
            this.colIsFOC.ReadOnly = true;
            this.colIsFOC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsFOC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboPrinter);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(55, 436);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 72);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Printer";
            // 
            // cboPrinter
            // 
            this.cboPrinter.FormattingEnabled = true;
            this.cboPrinter.Items.AddRange(new object[] {
            "Slip",
            "A5 Voucher",
            "A4 Voucher"});
            this.cboPrinter.Location = new System.Drawing.Point(26, 28);
            this.cboPrinter.Name = "cboPrinter";
            this.cboPrinter.Size = new System.Drawing.Size(233, 28);
            this.cboPrinter.TabIndex = 0;
            // 
            // InvoicePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 698);
            this.Controls.Add(this.dgvSaleItem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InvoicePayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Payment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItem)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSaleItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsFOC;
        private System.Windows.Forms.TextBox txtBalanceAmount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNetAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPaymentNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTableOrRoom;
        private System.Windows.Forms.TextBox txtServiceAmt;
        private System.Windows.Forms.TextBox txtSerPercent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDeliveryFee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkFOC;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboPrintType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboSaleType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPaidFrom;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboPrinter;
    }
}