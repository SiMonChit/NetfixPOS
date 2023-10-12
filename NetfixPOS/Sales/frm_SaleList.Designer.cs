
namespace NetfixPOS.Sales
{
    partial class frm_SaleList
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
            this.btnRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtp_ToDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dtp_FromDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnPrint = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvSaleHeaderList = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.colSaleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBalanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNetAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrintDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleHeaderList)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnRefresh);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.dtp_ToDate);
            this.kryptonPanel1.Controls.Add(this.dtp_FromDate);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlToolTip;
            this.kryptonPanel1.Size = new System.Drawing.Size(1673, 87);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.btnRefresh.Location = new System.Drawing.Point(619, 28);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 41);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Values.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(321, 29);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(77, 29);
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "To Date";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(26, 29);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(98, 29);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "From Date";
            // 
            // dtp_ToDate
            // 
            this.dtp_ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ToDate.Location = new System.Drawing.Point(404, 29);
            this.dtp_ToDate.Name = "dtp_ToDate";
            this.dtp_ToDate.Size = new System.Drawing.Size(140, 30);
            this.dtp_ToDate.TabIndex = 1;
            this.dtp_ToDate.UpDownButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            // 
            // dtp_FromDate
            // 
            this.dtp_FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FromDate.Location = new System.Drawing.Point(146, 28);
            this.dtp_FromDate.Name = "dtp_FromDate";
            this.dtp_FromDate.Size = new System.Drawing.Size(140, 30);
            this.dtp_FromDate.TabIndex = 0;
            this.dtp_FromDate.UpDownButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.btnPrint);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel2.Location = new System.Drawing.Point(1510, 87);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(163, 601);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.btnPrint.Location = new System.Drawing.Point(30, 22);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(112, 39);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Values.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgvSaleHeaderList
            // 
            this.dgvSaleHeaderList.AllowUserToAddRows = false;
            this.dgvSaleHeaderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleHeaderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSaleId,
            this.colInvNo,
            this.colTotalAmount,
            this.colBalanceAmount,
            this.colDiscountAmount,
            this.colNetAmount,
            this.colInvoiceStatus,
            this.colInvDate,
            this.colPrintDate,
            this.colUserID,
            this.colUserName});
            this.dgvSaleHeaderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSaleHeaderList.Location = new System.Drawing.Point(0, 87);
            this.dgvSaleHeaderList.Name = "dgvSaleHeaderList";
            this.dgvSaleHeaderList.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.dgvSaleHeaderList.RowHeadersWidth = 50;
            this.dgvSaleHeaderList.RowTemplate.Height = 28;
            this.dgvSaleHeaderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaleHeaderList.Size = new System.Drawing.Size(1510, 601);
            this.dgvSaleHeaderList.TabIndex = 2;
            this.dgvSaleHeaderList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaleHeaderList_CellClick);
            this.dgvSaleHeaderList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSaleHeaderList_DataBindingComplete);
            // 
            // colSaleId
            // 
            this.colSaleId.DataPropertyName = "SaleId";
            this.colSaleId.HeaderText = "SaleId";
            this.colSaleId.MinimumWidth = 8;
            this.colSaleId.Name = "colSaleId";
            this.colSaleId.ReadOnly = true;
            this.colSaleId.Visible = false;
            this.colSaleId.Width = 150;
            // 
            // colInvNo
            // 
            this.colInvNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colInvNo.DataPropertyName = "InvNo";
            this.colInvNo.HeaderText = "Inv No";
            this.colInvNo.MinimumWidth = 8;
            this.colInvNo.Name = "colInvNo";
            this.colInvNo.ReadOnly = true;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTotalAmount.DataPropertyName = "TotalAmount";
            this.colTotalAmount.HeaderText = "TotalAmount";
            this.colTotalAmount.MinimumWidth = 8;
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.ReadOnly = true;
            // 
            // colBalanceAmount
            // 
            this.colBalanceAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBalanceAmount.DataPropertyName = "BalanceAmount";
            this.colBalanceAmount.HeaderText = "Balance Amount";
            this.colBalanceAmount.MinimumWidth = 8;
            this.colBalanceAmount.Name = "colBalanceAmount";
            this.colBalanceAmount.ReadOnly = true;
            // 
            // colDiscountAmount
            // 
            this.colDiscountAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDiscountAmount.DataPropertyName = "DiscountAmount";
            this.colDiscountAmount.HeaderText = "DiscountAmount";
            this.colDiscountAmount.MinimumWidth = 8;
            this.colDiscountAmount.Name = "colDiscountAmount";
            this.colDiscountAmount.ReadOnly = true;
            // 
            // colNetAmount
            // 
            this.colNetAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNetAmount.DataPropertyName = "NetAmount";
            this.colNetAmount.HeaderText = "NetAmount";
            this.colNetAmount.MinimumWidth = 8;
            this.colNetAmount.Name = "colNetAmount";
            this.colNetAmount.ReadOnly = true;
            // 
            // colInvoiceStatus
            // 
            this.colInvoiceStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colInvoiceStatus.DataPropertyName = "InvoiceStatus";
            this.colInvoiceStatus.HeaderText = "InvoiceStatus";
            this.colInvoiceStatus.MinimumWidth = 8;
            this.colInvoiceStatus.Name = "colInvoiceStatus";
            this.colInvoiceStatus.ReadOnly = true;
            // 
            // colInvDate
            // 
            this.colInvDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colInvDate.DataPropertyName = "InvDate";
            this.colInvDate.HeaderText = "Inv Date";
            this.colInvDate.MinimumWidth = 8;
            this.colInvDate.Name = "colInvDate";
            this.colInvDate.ReadOnly = true;
            // 
            // colPrintDate
            // 
            this.colPrintDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPrintDate.DataPropertyName = "InvDate";
            this.colPrintDate.HeaderText = "PrintDate";
            this.colPrintDate.MinimumWidth = 8;
            this.colPrintDate.Name = "colPrintDate";
            this.colPrintDate.ReadOnly = true;
            // 
            // colUserID
            // 
            this.colUserID.DataPropertyName = "UserID";
            this.colUserID.HeaderText = "UserID";
            this.colUserID.MinimumWidth = 8;
            this.colUserID.Name = "colUserID";
            this.colUserID.ReadOnly = true;
            this.colUserID.Visible = false;
            this.colUserID.Width = 150;
            // 
            // colUserName
            // 
            this.colUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUserName.DataPropertyName = "UserName";
            this.colUserName.HeaderText = "Sale Person";
            this.colUserName.MinimumWidth = 8;
            this.colUserName.Name = "colUserName";
            // 
            // frm_SaleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1673, 688);
            this.Controls.Add(this.dgvSaleHeaderList);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "frm_SaleList";
            this.Text = "SaleList";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleHeaderList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvSaleHeaderList;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtp_ToDate;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtp_FromDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRefresh;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBalanceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscountAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNetAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrintDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
    }
}