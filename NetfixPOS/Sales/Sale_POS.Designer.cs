
namespace NetfixPOS.Sales
{
    partial class Sale_POS
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnNewVoucher = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnRoom = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnTable = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnJoin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnPayment = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnPaidConfirm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvSaleInvoice = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJoin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnNewVoucher);
            this.panel1.Controls.Add(this.btnRoom);
            this.panel1.Controls.Add(this.btnTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1510, 125);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1126, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sale Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(1216, 18);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(274, 26);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(384, 3);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 122);
            this.btnUpdate.StateNormal.Content.Padding = new System.Windows.Forms.Padding(-1, 50, -1, -1);
            this.btnUpdate.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Values.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNewVoucher
            // 
            this.btnNewVoucher.Location = new System.Drawing.Point(256, 3);
            this.btnNewVoucher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewVoucher.Name = "btnNewVoucher";
            this.btnNewVoucher.Size = new System.Drawing.Size(124, 122);
            this.btnNewVoucher.StateNormal.Content.Padding = new System.Windows.Forms.Padding(-1, 50, -1, -1);
            this.btnNewVoucher.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewVoucher.TabIndex = 8;
            this.btnNewVoucher.Values.Text = "New";
            this.btnNewVoucher.Click += new System.EventHandler(this.btnNewVoucher_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.Location = new System.Drawing.Point(130, 3);
            this.btnRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(124, 122);
            this.btnRoom.StateNormal.Content.Padding = new System.Windows.Forms.Padding(-1, 50, -1, -1);
            this.btnRoom.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.TabIndex = 7;
            this.btnRoom.Values.Text = "Room";
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click_1);
            // 
            // btnTable
            // 
            this.btnTable.Location = new System.Drawing.Point(4, 3);
            this.btnTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(124, 122);
            this.btnTable.StateNormal.Content.Padding = new System.Windows.Forms.Padding(-1, 50, -1, -1);
            this.btnTable.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.TabIndex = 6;
            this.btnTable.Values.Text = "Table";
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(28, 8);
            this.btnJoin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(156, 65);
            this.btnJoin.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoin.TabIndex = 12;
            this.btnJoin.Values.Text = "Join Table";
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnPayment);
            this.kryptonPanel1.Controls.Add(this.btnRefresh);
            this.kryptonPanel1.Controls.Add(this.btnPaidConfirm);
            this.kryptonPanel1.Controls.Add(this.btnJoin);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel1.Location = new System.Drawing.Point(1302, 125);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.kryptonPanel1.Size = new System.Drawing.Size(208, 572);
            this.kryptonPanel1.TabIndex = 2;
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(28, 82);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(156, 65);
            this.btnPayment.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.TabIndex = 15;
            this.btnPayment.Values.Text = "Payment";
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(28, 229);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(156, 65);
            this.btnRefresh.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Values.Text = "Refresh";
            // 
            // btnPaidConfirm
            // 
            this.btnPaidConfirm.Location = new System.Drawing.Point(28, 155);
            this.btnPaidConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPaidConfirm.Name = "btnPaidConfirm";
            this.btnPaidConfirm.Size = new System.Drawing.Size(156, 65);
            this.btnPaidConfirm.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaidConfirm.TabIndex = 13;
            this.btnPaidConfirm.Values.Text = "Paid Confirm";
            this.btnPaidConfirm.Click += new System.EventHandler(this.btnPaidConfirm_Click);
            // 
            // dgvSaleInvoice
            // 
            this.dgvSaleInvoice.AllowUserToAddRows = false;
            this.dgvSaleInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colJoin});
            this.dgvSaleInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSaleInvoice.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dgvSaleInvoice.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.dgvSaleInvoice.Location = new System.Drawing.Point(0, 125);
            this.dgvSaleInvoice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSaleInvoice.Name = "dgvSaleInvoice";
            this.dgvSaleInvoice.ReadOnly = true;
            this.dgvSaleInvoice.RowHeadersWidth = 62;
            this.dgvSaleInvoice.RowTemplate.Height = 50;
            this.dgvSaleInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaleInvoice.Size = new System.Drawing.Size(1302, 572);
            this.dgvSaleInvoice.TabIndex = 3;
            this.dgvSaleInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaleInvoice_CellContentClick);
            // 
            // colNo
            // 
            this.colNo.HeaderText = "No";
            this.colNo.MinimumWidth = 8;
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Width = 150;
            // 
            // colJoin
            // 
            this.colJoin.HeaderText = "Join";
            this.colJoin.MinimumWidth = 8;
            this.colJoin.Name = "colJoin";
            this.colJoin.ReadOnly = true;
            this.colJoin.Width = 150;
            // 
            // Sale_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 697);
            this.Controls.Add(this.dgvSaleInvoice);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Sale_POS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale POS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTable;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRoom;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNewVoucher;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnJoin;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvSaleInvoice;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPaidConfirm;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRefresh;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colJoin;
    }
}