
namespace NetfixPOS.Admin
{
    partial class UserPermission
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
            this.chkIsView = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.chkIsDelete = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.chkIsUpdate = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.chkIsSave = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboControlForm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboUsers = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvPermission = new System.Windows.Forms.DataGridView();
            this.chkSearchByUser = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.colPermissionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colControlForm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colControlId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsSave = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colIsUpdate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colIsDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colIsView = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermission)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkSearchByUser);
            this.panel1.Controls.Add(this.chkIsView);
            this.panel1.Controls.Add(this.chkIsDelete);
            this.panel1.Controls.Add(this.chkIsUpdate);
            this.panel1.Controls.Add(this.chkIsSave);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboControlForm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboUsers);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 666);
            this.panel1.TabIndex = 2;
            // 
            // chkIsView
            // 
            this.chkIsView.Location = new System.Drawing.Point(307, 330);
            this.chkIsView.Name = "chkIsView";
            this.chkIsView.Size = new System.Drawing.Size(65, 29);
            this.chkIsView.TabIndex = 14;
            this.chkIsView.Values.Text = "View";
            // 
            // chkIsDelete
            // 
            this.chkIsDelete.Location = new System.Drawing.Point(307, 283);
            this.chkIsDelete.Name = "chkIsDelete";
            this.chkIsDelete.Size = new System.Drawing.Size(78, 29);
            this.chkIsDelete.TabIndex = 13;
            this.chkIsDelete.Values.Text = "Delete";
            // 
            // chkIsUpdate
            // 
            this.chkIsUpdate.Location = new System.Drawing.Point(307, 238);
            this.chkIsUpdate.Name = "chkIsUpdate";
            this.chkIsUpdate.Size = new System.Drawing.Size(85, 29);
            this.chkIsUpdate.TabIndex = 12;
            this.chkIsUpdate.Values.Text = "Update";
            // 
            // chkIsSave
            // 
            this.chkIsSave.Location = new System.Drawing.Point(307, 190);
            this.chkIsSave.Name = "chkIsSave";
            this.chkIsSave.Size = new System.Drawing.Size(63, 29);
            this.chkIsSave.TabIndex = 11;
            this.chkIsSave.Values.Text = "Save";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Control Form";
            // 
            // cboControlForm
            // 
            this.cboControlForm.FormattingEnabled = true;
            this.cboControlForm.Location = new System.Drawing.Point(127, 126);
            this.cboControlForm.Name = "cboControlForm";
            this.cboControlForm.Size = new System.Drawing.Size(264, 28);
            this.cboControlForm.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "User";
            // 
            // cboUsers
            // 
            this.cboUsers.FormattingEnabled = true;
            this.cboUsers.Location = new System.Drawing.Point(127, 67);
            this.cboUsers.Name = "cboUsers";
            this.cboUsers.Size = new System.Drawing.Size(264, 28);
            this.cboUsers.TabIndex = 7;
            this.cboUsers.SelectionChangeCommitted += new System.EventHandler(this.cboUsers_SelectionChangeCommitted);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(285, 394);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 37);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvPermission
            // 
            this.dgvPermission.AllowUserToAddRows = false;
            this.dgvPermission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermission.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPermissionId,
            this.colUserID,
            this.colUserName,
            this.colControlForm,
            this.colControlId,
            this.colIsSave,
            this.colIsUpdate,
            this.colIsDelete,
            this.colIsView,
            this.colIsActive,
            this.colEdit,
            this.colDel});
            this.dgvPermission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPermission.Location = new System.Drawing.Point(430, 0);
            this.dgvPermission.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPermission.Name = "dgvPermission";
            this.dgvPermission.RowHeadersWidth = 50;
            this.dgvPermission.RowTemplate.Height = 30;
            this.dgvPermission.Size = new System.Drawing.Size(1070, 666);
            this.dgvPermission.TabIndex = 5;
            this.dgvPermission.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermission_CellContentClick);
            this.dgvPermission.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPermission_DataBindingComplete);
            // 
            // chkSearchByUser
            // 
            this.chkSearchByUser.Location = new System.Drawing.Point(127, 32);
            this.chkSearchByUser.Name = "chkSearchByUser";
            this.chkSearchByUser.Size = new System.Drawing.Size(146, 29);
            this.chkSearchByUser.TabIndex = 15;
            this.chkSearchByUser.Values.Text = "Search By User";
            this.chkSearchByUser.CheckedChanged += new System.EventHandler(this.chkSearchByUser_CheckedChanged);
            // 
            // colPermissionId
            // 
            this.colPermissionId.DataPropertyName = "PermissionID";
            this.colPermissionId.HeaderText = "PermissionId";
            this.colPermissionId.MinimumWidth = 8;
            this.colPermissionId.Name = "colPermissionId";
            this.colPermissionId.Visible = false;
            this.colPermissionId.Width = 150;
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
            // colUserName
            // 
            this.colUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUserName.DataPropertyName = "UserName";
            this.colUserName.HeaderText = "UserName";
            this.colUserName.MinimumWidth = 8;
            this.colUserName.Name = "colUserName";
            // 
            // colControlForm
            // 
            this.colControlForm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colControlForm.DataPropertyName = "ControlForm";
            this.colControlForm.HeaderText = "ControlForm";
            this.colControlForm.MinimumWidth = 8;
            this.colControlForm.Name = "colControlForm";
            this.colControlForm.ReadOnly = true;
            // 
            // colControlId
            // 
            this.colControlId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colControlId.DataPropertyName = "ControlId";
            this.colControlId.FillWeight = 80F;
            this.colControlId.HeaderText = "ControlId";
            this.colControlId.MinimumWidth = 8;
            this.colControlId.Name = "colControlId";
            this.colControlId.ReadOnly = true;
            this.colControlId.Visible = false;
            // 
            // colIsSave
            // 
            this.colIsSave.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colIsSave.DataPropertyName = "IsSave";
            this.colIsSave.FillWeight = 50F;
            this.colIsSave.HeaderText = "Save";
            this.colIsSave.MinimumWidth = 8;
            this.colIsSave.Name = "colIsSave";
            this.colIsSave.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsSave.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colIsUpdate
            // 
            this.colIsUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colIsUpdate.DataPropertyName = "IsUpdate";
            this.colIsUpdate.FillWeight = 50F;
            this.colIsUpdate.HeaderText = "Update";
            this.colIsUpdate.MinimumWidth = 8;
            this.colIsUpdate.Name = "colIsUpdate";
            // 
            // colIsDelete
            // 
            this.colIsDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colIsDelete.DataPropertyName = "IsDelete";
            this.colIsDelete.FillWeight = 50F;
            this.colIsDelete.HeaderText = "Delete";
            this.colIsDelete.MinimumWidth = 8;
            this.colIsDelete.Name = "colIsDelete";
            // 
            // colIsView
            // 
            this.colIsView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colIsView.DataPropertyName = "IsView";
            this.colIsView.FillWeight = 50F;
            this.colIsView.HeaderText = "View";
            this.colIsView.MinimumWidth = 8;
            this.colIsView.Name = "colIsView";
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
            // colEdit
            // 
            this.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEdit.FillWeight = 50F;
            this.colEdit.HeaderText = "Edit";
            this.colEdit.MinimumWidth = 8;
            this.colEdit.Name = "colEdit";
            this.colEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.colDel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDel.Text = "Delete";
            this.colDel.UseColumnTextForButtonValue = true;
            // 
            // UserPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 666);
            this.Controls.Add(this.dgvPermission);
            this.Controls.Add(this.panel1);
            this.Name = "UserPermission";
            this.Text = "UserPermission";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermission)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboUsers;
        private System.Windows.Forms.DataGridView dgvPermission;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboControlForm;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chkIsView;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chkIsDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chkIsUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chkIsSave;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chkSearchByUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPermissionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colControlForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colControlId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsSave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsUpdate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsActive;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDel;
    }
}