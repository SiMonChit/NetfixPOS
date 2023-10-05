
namespace NetfixPOS.NewSetup
{
    partial class DamageForm
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
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDRNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApproverName = new System.Windows.Forms.TextBox();
            this.dtpDmg_Date = new System.Windows.Forms.DateTimePicker();
            this.txtCharges = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDmg_Desc = new System.Windows.Forms.TextBox();
            this.txtTableOrRoom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDamage = new System.Windows.Forms.DataGridView();
            this.colDamageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTableOrRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDmg_Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDmg_Charges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDmg_Approver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDmg_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCashReceiptId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnPayment);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1223, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 655);
            this.panel1.TabIndex = 0;
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(26, 118);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(114, 35);
            this.btnPayment.TabIndex = 2;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(26, 77);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 35);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(26, 36);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 35);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDRNo);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtApproverName);
            this.panel2.Controls.Add(this.dtpDmg_Date);
            this.panel2.Controls.Add(this.txtCharges);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtDmg_Desc);
            this.panel2.Controls.Add(this.txtTableOrRoom);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1223, 215);
            this.panel2.TabIndex = 1;
            // 
            // txtDRNo
            // 
            this.txtDRNo.Location = new System.Drawing.Point(142, 34);
            this.txtDRNo.Name = "txtDRNo";
            this.txtDRNo.ReadOnly = true;
            this.txtDRNo.Size = new System.Drawing.Size(183, 26);
            this.txtDRNo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "DR No";
            // 
            // txtApproverName
            // 
            this.txtApproverName.Location = new System.Drawing.Point(507, 161);
            this.txtApproverName.Name = "txtApproverName";
            this.txtApproverName.Size = new System.Drawing.Size(465, 26);
            this.txtApproverName.TabIndex = 9;
            // 
            // dtpDmg_Date
            // 
            this.dtpDmg_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDmg_Date.Location = new System.Drawing.Point(142, 159);
            this.dtpDmg_Date.Name = "dtpDmg_Date";
            this.dtpDmg_Date.Size = new System.Drawing.Size(183, 26);
            this.dtpDmg_Date.TabIndex = 8;
            // 
            // txtCharges
            // 
            this.txtCharges.Location = new System.Drawing.Point(142, 117);
            this.txtCharges.Name = "txtCharges";
            this.txtCharges.Size = new System.Drawing.Size(183, 26);
            this.txtCharges.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Charges";
            // 
            // txtDmg_Desc
            // 
            this.txtDmg_Desc.Location = new System.Drawing.Point(507, 33);
            this.txtDmg_Desc.Multiline = true;
            this.txtDmg_Desc.Name = "txtDmg_Desc";
            this.txtDmg_Desc.Size = new System.Drawing.Size(465, 102);
            this.txtDmg_Desc.TabIndex = 4;
            // 
            // txtTableOrRoom
            // 
            this.txtTableOrRoom.Location = new System.Drawing.Point(142, 78);
            this.txtTableOrRoom.Name = "txtTableOrRoom";
            this.txtTableOrRoom.Size = new System.Drawing.Size(183, 26);
            this.txtTableOrRoom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Remark";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Approver Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table / Room";
            // 
            // dgvDamage
            // 
            this.dgvDamage.AllowUserToAddRows = false;
            this.dgvDamage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDamage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDamageId,
            this.colTableOrRoom,
            this.colDmg_Desc,
            this.colDmg_Charges,
            this.colDmg_Approver,
            this.colUserID,
            this.colDmg_Date,
            this.colCashReceiptId,
            this.colIsActive,
            this.colEdit,
            this.colDel});
            this.dgvDamage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDamage.Location = new System.Drawing.Point(0, 215);
            this.dgvDamage.Name = "dgvDamage";
            this.dgvDamage.RowHeadersWidth = 50;
            this.dgvDamage.RowTemplate.Height = 28;
            this.dgvDamage.Size = new System.Drawing.Size(1223, 440);
            this.dgvDamage.TabIndex = 2;
            this.dgvDamage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDamage_CellContentClick);
            // 
            // colDamageId
            // 
            this.colDamageId.HeaderText = "DamageId";
            this.colDamageId.MinimumWidth = 8;
            this.colDamageId.Name = "colDamageId";
            this.colDamageId.Visible = false;
            this.colDamageId.Width = 150;
            // 
            // colTableOrRoom
            // 
            this.colTableOrRoom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTableOrRoom.DataPropertyName = "TableOrRoom";
            this.colTableOrRoom.FillWeight = 50F;
            this.colTableOrRoom.HeaderText = "Table / Room";
            this.colTableOrRoom.MinimumWidth = 8;
            this.colTableOrRoom.Name = "colTableOrRoom";
            // 
            // colDmg_Desc
            // 
            this.colDmg_Desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDmg_Desc.DataPropertyName = "Dmg_Description";
            this.colDmg_Desc.HeaderText = "Remark";
            this.colDmg_Desc.MinimumWidth = 8;
            this.colDmg_Desc.Name = "colDmg_Desc";
            // 
            // colDmg_Charges
            // 
            this.colDmg_Charges.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDmg_Charges.DataPropertyName = "Dmg_Charges";
            this.colDmg_Charges.FillWeight = 60F;
            this.colDmg_Charges.HeaderText = "Charges";
            this.colDmg_Charges.MinimumWidth = 8;
            this.colDmg_Charges.Name = "colDmg_Charges";
            // 
            // colDmg_Approver
            // 
            this.colDmg_Approver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDmg_Approver.DataPropertyName = "Dmg_Approver";
            this.colDmg_Approver.FillWeight = 80F;
            this.colDmg_Approver.HeaderText = "Approver";
            this.colDmg_Approver.MinimumWidth = 8;
            this.colDmg_Approver.Name = "colDmg_Approver";
            // 
            // colUserID
            // 
            this.colUserID.HeaderText = "UserID";
            this.colUserID.MinimumWidth = 8;
            this.colUserID.Name = "colUserID";
            this.colUserID.Visible = false;
            this.colUserID.Width = 150;
            // 
            // colDmg_Date
            // 
            this.colDmg_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDmg_Date.DataPropertyName = "Dmg_Date";
            this.colDmg_Date.FillWeight = 80F;
            this.colDmg_Date.HeaderText = "Date";
            this.colDmg_Date.MinimumWidth = 8;
            this.colDmg_Date.Name = "colDmg_Date";
            // 
            // colCashReceiptId
            // 
            this.colCashReceiptId.DataPropertyName = "CashReceiptId";
            this.colCashReceiptId.HeaderText = "CashReceiptId";
            this.colCashReceiptId.MinimumWidth = 8;
            this.colCashReceiptId.Name = "colCashReceiptId";
            this.colCashReceiptId.Visible = false;
            this.colCashReceiptId.Width = 150;
            // 
            // colIsActive
            // 
            this.colIsActive.HeaderText = "IsActive";
            this.colIsActive.MinimumWidth = 8;
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = false;
            this.colIsActive.Width = 150;
            // 
            // colEdit
            // 
            this.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEdit.FillWeight = 40F;
            this.colEdit.HeaderText = "Edit";
            this.colEdit.MinimumWidth = 8;
            this.colEdit.Name = "colEdit";
            this.colEdit.Text = "Edit";
            this.colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDel
            // 
            this.colDel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDel.FillWeight = 40F;
            this.colDel.HeaderText = "Del";
            this.colDel.MinimumWidth = 8;
            this.colDel.Name = "colDel";
            this.colDel.Text = "Delete";
            this.colDel.UseColumnTextForButtonValue = true;
            // 
            // DamageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 655);
            this.Controls.Add(this.dgvDamage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DamageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DamageForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDmg_Desc;
        private System.Windows.Forms.TextBox txtTableOrRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDmg_Date;
        private System.Windows.Forms.TextBox txtCharges;
        private System.Windows.Forms.TextBox txtApproverName;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvDamage;
        private System.Windows.Forms.TextBox txtDRNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDamageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTableOrRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDmg_Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDmg_Charges;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDmg_Approver;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDmg_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCashReceiptId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsActive;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDel;
    }
}