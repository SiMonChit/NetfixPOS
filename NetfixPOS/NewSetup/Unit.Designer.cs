
namespace NetfixPOS.NewSetup
{
    partial class Unit
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
            this.nudDefaultQty = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvUnit = new System.Windows.Forms.DataGridView();
            this.colUnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDefaultQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefaultQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.nudDefaultQty);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtUnitName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 66);
            this.panel1.TabIndex = 2;
            // 
            // nudDefaultQty
            // 
            this.nudDefaultQty.Location = new System.Drawing.Point(113, 36);
            this.nudDefaultQty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDefaultQty.Name = "nudDefaultQty";
            this.nudDefaultQty.Size = new System.Drawing.Size(136, 23);
            this.nudDefaultQty.TabIndex = 4;
            this.nudDefaultQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Default Qty";
            // 
            // txtUnitName
            // 
            this.txtUnitName.Location = new System.Drawing.Point(113, 10);
            this.txtUnitName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(136, 23);
            this.txtUnitName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unit Name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(283, 10);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvUnit
            // 
            this.dgvUnit.AllowUserToAddRows = false;
            this.dgvUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUnitID,
            this.colUnitName,
            this.colDefaultQty,
            this.colEdit,
            this.colDel});
            this.dgvUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUnit.Location = new System.Drawing.Point(0, 66);
            this.dgvUnit.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUnit.Name = "dgvUnit";
            this.dgvUnit.RowHeadersWidth = 50;
            this.dgvUnit.RowTemplate.Height = 28;
            this.dgvUnit.Size = new System.Drawing.Size(525, 390);
            this.dgvUnit.TabIndex = 3;
            this.dgvUnit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnit_CellContentClick);
            this.dgvUnit.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvUnit_DataBindingComplete);
            // 
            // colUnitID
            // 
            this.colUnitID.DataPropertyName = "UnitID";
            this.colUnitID.HeaderText = "UnitID";
            this.colUnitID.MinimumWidth = 8;
            this.colUnitID.Name = "colUnitID";
            this.colUnitID.Visible = false;
            this.colUnitID.Width = 150;
            // 
            // colUnitName
            // 
            this.colUnitName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUnitName.DataPropertyName = "UnitName";
            this.colUnitName.HeaderText = "UnitName";
            this.colUnitName.MinimumWidth = 8;
            this.colUnitName.Name = "colUnitName";
            // 
            // colDefaultQty
            // 
            this.colDefaultQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDefaultQty.DataPropertyName = "DefaultQty";
            this.colDefaultQty.FillWeight = 80F;
            this.colDefaultQty.HeaderText = "DefaultQty";
            this.colDefaultQty.MinimumWidth = 8;
            this.colDefaultQty.Name = "colDefaultQty";
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
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(369, 10);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(78, 30);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Unit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 456);
            this.Controls.Add(this.dgvUnit);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Unit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefaultQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nudDefaultQty;
        private System.Windows.Forms.DataGridView dgvUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDefaultQty;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDel;
        private System.Windows.Forms.Button btnNew;
    }
}