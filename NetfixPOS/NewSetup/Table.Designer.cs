
namespace NetfixPOS.NewSetup
{
    partial class Table
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
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTableNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.chkIsDefault = new System.Windows.Forms.CheckBox();
            this.colTableID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTableNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsDefault = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.chkIsDefault);
            this.panel1.Controls.Add(this.txtTableName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTableNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 353);
            this.panel1.TabIndex = 0;
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(83, 45);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(131, 20);
            this.txtTableName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Table Name";
            // 
            // txtTableNo
            // 
            this.txtTableNo.Location = new System.Drawing.Point(83, 21);
            this.txtTableNo.Name = "txtTableNo";
            this.txtTableNo.Size = new System.Drawing.Size(131, 20);
            this.txtTableNo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Table No";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(83, 117);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 24);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTableID,
            this.colTableNo,
            this.colTableName,
            this.colCompanyId,
            this.colIsDeleted,
            this.colIsAvailable,
            this.colIsDefault,
            this.colEdit,
            this.colDel});
            this.dgvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTable.Location = new System.Drawing.Point(233, 0);
            this.dgvTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersWidth = 62;
            this.dgvTable.RowTemplate.Height = 28;
            this.dgvTable.Size = new System.Drawing.Size(555, 353);
            this.dgvTable.TabIndex = 1;
            this.dgvTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellContentClick);
            this.dgvTable.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvTable_DataBindingComplete);
            // 
            // chkIsDefault
            // 
            this.chkIsDefault.AutoSize = true;
            this.chkIsDefault.Location = new System.Drawing.Point(83, 83);
            this.chkIsDefault.Name = "chkIsDefault";
            this.chkIsDefault.Size = new System.Drawing.Size(60, 17);
            this.chkIsDefault.TabIndex = 8;
            this.chkIsDefault.Text = "Default";
            this.chkIsDefault.UseVisualStyleBackColor = true;
            // 
            // colTableID
            // 
            this.colTableID.DataPropertyName = "TableID";
            this.colTableID.HeaderText = "TableID";
            this.colTableID.MinimumWidth = 8;
            this.colTableID.Name = "colTableID";
            this.colTableID.Visible = false;
            this.colTableID.Width = 150;
            // 
            // colTableNo
            // 
            this.colTableNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTableNo.DataPropertyName = "TableNo";
            this.colTableNo.FillWeight = 80F;
            this.colTableNo.HeaderText = "Table No";
            this.colTableNo.MinimumWidth = 8;
            this.colTableNo.Name = "colTableNo";
            this.colTableNo.ReadOnly = true;
            // 
            // colTableName
            // 
            this.colTableName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTableName.DataPropertyName = "TableName";
            this.colTableName.HeaderText = "Table Name";
            this.colTableName.MinimumWidth = 8;
            this.colTableName.Name = "colTableName";
            this.colTableName.ReadOnly = true;
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
            // colIsDeleted
            // 
            this.colIsDeleted.DataPropertyName = "IsDeleted";
            this.colIsDeleted.HeaderText = "Is Deleted";
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
            this.colIsAvailable.HeaderText = "Is Available";
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
            this.colIsDefault.ReadOnly = true;
            this.colIsDefault.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsDefault.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.btnNew.Location = new System.Drawing.Point(83, 147);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(67, 24);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 353);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTableNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkIsDefault;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTableID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTableNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsDeleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsAvailable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsDefault;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDel;
        private System.Windows.Forms.Button btnNew;
    }
}