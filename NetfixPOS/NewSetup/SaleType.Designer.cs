
namespace NetfixPOS.NewSetup
{
    partial class SaleType
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
            this.txtSaleType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvSaleType = new System.Windows.Forms.DataGridView();
            this.colSaleTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleType)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSaleType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 93);
            this.panel1.TabIndex = 2;
            // 
            // txtSaleType
            // 
            this.txtSaleType.Location = new System.Drawing.Point(117, 33);
            this.txtSaleType.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaleType.Name = "txtSaleType";
            this.txtSaleType.Size = new System.Drawing.Size(273, 26);
            this.txtSaleType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sale Type";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(398, 28);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 37);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvSaleType
            // 
            this.dgvSaleType.AllowUserToAddRows = false;
            this.dgvSaleType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSaleTypeId,
            this.colSaleTypeName,
            this.colIsActive,
            this.colEdit,
            this.colDel});
            this.dgvSaleType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSaleType.Location = new System.Drawing.Point(0, 93);
            this.dgvSaleType.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSaleType.Name = "dgvSaleType";
            this.dgvSaleType.RowHeadersWidth = 62;
            this.dgvSaleType.RowTemplate.Height = 28;
            this.dgvSaleType.Size = new System.Drawing.Size(680, 545);
            this.dgvSaleType.TabIndex = 4;
            this.dgvSaleType.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSaleType_DataBindingComplete);
            // 
            // colSaleTypeId
            // 
            this.colSaleTypeId.DataPropertyName = "SaleTypeId";
            this.colSaleTypeId.HeaderText = "SaleTypeId";
            this.colSaleTypeId.MinimumWidth = 8;
            this.colSaleTypeId.Name = "colSaleTypeId";
            this.colSaleTypeId.Visible = false;
            this.colSaleTypeId.Width = 150;
            // 
            // colSaleTypeName
            // 
            this.colSaleTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSaleTypeName.DataPropertyName = "SaleTypeName";
            this.colSaleTypeName.HeaderText = "Sale Type";
            this.colSaleTypeName.MinimumWidth = 8;
            this.colSaleTypeName.Name = "colSaleTypeName";
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
            this.colEdit.FillWeight = 30F;
            this.colEdit.HeaderText = "Edit";
            this.colEdit.MinimumWidth = 8;
            this.colEdit.Name = "colEdit";
            this.colEdit.Text = "Edit";
            this.colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDel
            // 
            this.colDel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDel.FillWeight = 30F;
            this.colDel.HeaderText = "Delete";
            this.colDel.MinimumWidth = 8;
            this.colDel.Name = "colDel";
            this.colDel.Text = "Delete";
            this.colDel.UseColumnTextForButtonValue = true;
            // 
            // SaleType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 638);
            this.Controls.Add(this.dgvSaleType);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SaleType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleType";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSaleType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvSaleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsActive;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDel;
    }
}