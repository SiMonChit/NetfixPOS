
namespace NetfixPOS.Admin
{
    partial class frm_EndOfDay
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
            this.btnDayEnd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgvEndOfDay = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.coleod_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coleod_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dtp_eod_detail = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dgvEndOfDay_Audit = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.coleod_id_for_today = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coleod_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVoucherQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVoucherAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndOfDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndOfDay_Audit)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnDayEnd);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel1.Location = new System.Drawing.Point(1390, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(186, 685);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // btnDayEnd
            // 
            this.btnDayEnd.Location = new System.Drawing.Point(22, 13);
            this.btnDayEnd.Name = "btnDayEnd";
            this.btnDayEnd.Size = new System.Drawing.Size(148, 38);
            this.btnDayEnd.TabIndex = 0;
            this.btnDayEnd.Values.Text = "Day End";
            this.btnDayEnd.Click += new System.EventHandler(this.btnDayEnd_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.dgvEndOfDay);
            this.kryptonPanel2.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(476, 685);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // dgvEndOfDay
            // 
            this.dgvEndOfDay.AllowUserToAddRows = false;
            this.dgvEndOfDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEndOfDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coleod_id,
            this.coleod_Date,
            this.colUserID,
            this.colUser,
            this.colIsActive});
            this.dgvEndOfDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEndOfDay.Location = new System.Drawing.Point(0, 68);
            this.dgvEndOfDay.Name = "dgvEndOfDay";
            this.dgvEndOfDay.RowHeadersWidth = 50;
            this.dgvEndOfDay.RowTemplate.Height = 28;
            this.dgvEndOfDay.Size = new System.Drawing.Size(476, 617);
            this.dgvEndOfDay.TabIndex = 4;
            // 
            // coleod_id
            // 
            this.coleod_id.DataPropertyName = "eod_id";
            this.coleod_id.HeaderText = "eod_id";
            this.coleod_id.MinimumWidth = 8;
            this.coleod_id.Name = "coleod_id";
            this.coleod_id.Visible = false;
            this.coleod_id.Width = 150;
            // 
            // coleod_Date
            // 
            this.coleod_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coleod_Date.DataPropertyName = "eod_Date";
            this.coleod_Date.HeaderText = "End Date";
            this.coleod_Date.MinimumWidth = 8;
            this.coleod_Date.Name = "coleod_Date";
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
            // colUser
            // 
            this.colUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUser.DataPropertyName = "UserName";
            this.colUser.HeaderText = "User";
            this.colUser.MinimumWidth = 8;
            this.colUser.Name = "colUser";
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
            // kryptonPanel4
            // 
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.kryptonPanel4.Size = new System.Drawing.Size(476, 68);
            this.kryptonPanel4.TabIndex = 3;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.dtp_eod_detail);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel3.Location = new System.Drawing.Point(476, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.kryptonPanel3.Size = new System.Drawing.Size(914, 68);
            this.kryptonPanel3.TabIndex = 2;
            // 
            // dtp_eod_detail
            // 
            this.dtp_eod_detail.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_eod_detail.Location = new System.Drawing.Point(713, 21);
            this.dtp_eod_detail.Name = "dtp_eod_detail";
            this.dtp_eod_detail.Size = new System.Drawing.Size(142, 30);
            this.dtp_eod_detail.TabIndex = 2;
            this.dtp_eod_detail.ValueChanged += new System.EventHandler(this.dtp_eod_detail_ValueChanged);
            // 
            // dgvEndOfDay_Audit
            // 
            this.dgvEndOfDay_Audit.AllowUserToAddRows = false;
            this.dgvEndOfDay_Audit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEndOfDay_Audit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coleod_id_for_today,
            this.coleod_desc,
            this.colVoucherQty,
            this.colVoucherAmount});
            this.dgvEndOfDay_Audit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEndOfDay_Audit.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dgvEndOfDay_Audit.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.InputControlRibbon;
            this.dgvEndOfDay_Audit.Location = new System.Drawing.Point(476, 68);
            this.dgvEndOfDay_Audit.Name = "dgvEndOfDay_Audit";
            this.dgvEndOfDay_Audit.RowHeadersWidth = 62;
            this.dgvEndOfDay_Audit.RowTemplate.Height = 28;
            this.dgvEndOfDay_Audit.Size = new System.Drawing.Size(914, 617);
            this.dgvEndOfDay_Audit.TabIndex = 3;
            this.dgvEndOfDay_Audit.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvEndOfDay_Audit_DataBindingComplete);
            // 
            // coleod_id_for_today
            // 
            this.coleod_id_for_today.DataPropertyName = "eod_id";
            this.coleod_id_for_today.HeaderText = "today_eod_id";
            this.coleod_id_for_today.MinimumWidth = 8;
            this.coleod_id_for_today.Name = "coleod_id_for_today";
            this.coleod_id_for_today.Visible = false;
            this.coleod_id_for_today.Width = 150;
            // 
            // coleod_desc
            // 
            this.coleod_desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coleod_desc.DataPropertyName = "eod_desc";
            this.coleod_desc.HeaderText = "Dsecription";
            this.coleod_desc.MinimumWidth = 8;
            this.coleod_desc.Name = "coleod_desc";
            this.coleod_desc.ReadOnly = true;
            // 
            // colVoucherQty
            // 
            this.colVoucherQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colVoucherQty.DataPropertyName = "VoucherQty";
            this.colVoucherQty.FillWeight = 30F;
            this.colVoucherQty.HeaderText = "Qty";
            this.colVoucherQty.MinimumWidth = 8;
            this.colVoucherQty.Name = "colVoucherQty";
            this.colVoucherQty.ReadOnly = true;
            // 
            // colVoucherAmount
            // 
            this.colVoucherAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colVoucherAmount.DataPropertyName = "VoucherAmount";
            this.colVoucherAmount.FillWeight = 40F;
            this.colVoucherAmount.HeaderText = "Amount";
            this.colVoucherAmount.MinimumWidth = 8;
            this.colVoucherAmount.Name = "colVoucherAmount";
            this.colVoucherAmount.ReadOnly = true;
            // 
            // frm_EndOfDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 685);
            this.Controls.Add(this.dgvEndOfDay_Audit);
            this.Controls.Add(this.kryptonPanel3);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "frm_EndOfDay";
            this.Text = "End Of Day";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndOfDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndOfDay_Audit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDayEnd;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvEndOfDay;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtp_eod_detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn coleod_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn coleod_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsActive;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvEndOfDay_Audit;
        private System.Windows.Forms.DataGridViewTextBoxColumn coleod_id_for_today;
        private System.Windows.Forms.DataGridViewTextBoxColumn coleod_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVoucherQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVoucherAmount;
    }
}