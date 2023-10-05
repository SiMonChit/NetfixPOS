
namespace NetfixPOS.NewSetup
{
    partial class Room
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
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkIsDefault = new System.Windows.Forms.CheckBox();
            this.colRoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsDefault = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRoom
            // 
            this.dgvRoom.AllowUserToAddRows = false;
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRoomId,
            this.colRoomNo,
            this.colRoomName,
            this.colCompanyId,
            this.colModifiedDate,
            this.colIsDeleted,
            this.colIsAvailable,
            this.colIsDefault,
            this.colEdit,
            this.colDel});
            this.dgvRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoom.Location = new System.Drawing.Point(229, 0);
            this.dgvRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.RowHeadersWidth = 50;
            this.dgvRoom.RowTemplate.Height = 28;
            this.dgvRoom.Size = new System.Drawing.Size(521, 353);
            this.dgvRoom.TabIndex = 3;
            this.dgvRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoom_CellContentClick);
            this.dgvRoom.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvRoom_DataBindingComplete);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.chkIsDefault);
            this.panel1.Controls.Add(this.txtRoomName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtRoomNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 353);
            this.panel1.TabIndex = 2;
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(87, 44);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(131, 20);
            this.txtRoomName.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Room Name";
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Location = new System.Drawing.Point(87, 21);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(131, 20);
            this.txtRoomNo.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Room No";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(87, 109);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 24);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkIsDefault
            // 
            this.chkIsDefault.AutoSize = true;
            this.chkIsDefault.Location = new System.Drawing.Point(87, 81);
            this.chkIsDefault.Name = "chkIsDefault";
            this.chkIsDefault.Size = new System.Drawing.Size(60, 17);
            this.chkIsDefault.TabIndex = 13;
            this.chkIsDefault.Text = "Default";
            this.chkIsDefault.UseVisualStyleBackColor = true;
            // 
            // colRoomId
            // 
            this.colRoomId.DataPropertyName = "RoomId";
            this.colRoomId.HeaderText = "RoomId";
            this.colRoomId.MinimumWidth = 8;
            this.colRoomId.Name = "colRoomId";
            this.colRoomId.Visible = false;
            this.colRoomId.Width = 150;
            // 
            // colRoomNo
            // 
            this.colRoomNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRoomNo.DataPropertyName = "RoomNo";
            this.colRoomNo.FillWeight = 80F;
            this.colRoomNo.HeaderText = "Room No";
            this.colRoomNo.MinimumWidth = 8;
            this.colRoomNo.Name = "colRoomNo";
            // 
            // colRoomName
            // 
            this.colRoomName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRoomName.DataPropertyName = "RoomName";
            this.colRoomName.HeaderText = "Room Name";
            this.colRoomName.MinimumWidth = 8;
            this.colRoomName.Name = "colRoomName";
            // 
            // colCompanyId
            // 
            this.colCompanyId.DataPropertyName = "CompanyId";
            this.colCompanyId.HeaderText = "CompanyId";
            this.colCompanyId.MinimumWidth = 8;
            this.colCompanyId.Name = "colCompanyId";
            this.colCompanyId.Visible = false;
            this.colCompanyId.Width = 150;
            // 
            // colModifiedDate
            // 
            this.colModifiedDate.DataPropertyName = "ModifiedDate";
            this.colModifiedDate.HeaderText = "ModifiedDate";
            this.colModifiedDate.MinimumWidth = 8;
            this.colModifiedDate.Name = "colModifiedDate";
            this.colModifiedDate.Visible = false;
            this.colModifiedDate.Width = 150;
            // 
            // colIsDeleted
            // 
            this.colIsDeleted.DataPropertyName = "IsDeleted";
            this.colIsDeleted.HeaderText = "IsDeleted";
            this.colIsDeleted.MinimumWidth = 8;
            this.colIsDeleted.Name = "colIsDeleted";
            this.colIsDeleted.Visible = false;
            this.colIsDeleted.Width = 150;
            // 
            // colIsAvailable
            // 
            this.colIsAvailable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colIsAvailable.DataPropertyName = "IsAvailable";
            this.colIsAvailable.FillWeight = 50F;
            this.colIsAvailable.HeaderText = "IsAvailable";
            this.colIsAvailable.MinimumWidth = 8;
            this.colIsAvailable.Name = "colIsAvailable";
            // 
            // colIsDefault
            // 
            this.colIsDefault.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colIsDefault.DataPropertyName = "IsDefault";
            this.colIsDefault.FillWeight = 50F;
            this.colIsDefault.HeaderText = "Default";
            this.colIsDefault.Name = "colIsDefault";
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
            this.colDel.HeaderText = "Delete";
            this.colDel.MinimumWidth = 8;
            this.colDel.Name = "colDel";
            this.colDel.Text = "Delete";
            this.colDel.UseColumnTextForButtonValue = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(87, 139);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(67, 24);
            this.btnNew.TabIndex = 14;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 353);
            this.Controls.Add(this.dgvRoom);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Room";
            this.Text = "Room";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModifiedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsDeleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsAvailable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsDefault;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDel;
        private System.Windows.Forms.CheckBox chkIsDefault;
        private System.Windows.Forms.Button btnNew;
    }
}