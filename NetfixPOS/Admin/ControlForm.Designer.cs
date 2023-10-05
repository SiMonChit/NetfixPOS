
namespace NetfixPOS.Admin
{
    partial class ControlForm
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
            this.txtControlName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvControlForm = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.colControlId = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.colControlForm = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.colIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.colDel = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlForm)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.txtControlName);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.btnSave);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(274, 669);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // txtControlName
            // 
            this.txtControlName.Location = new System.Drawing.Point(17, 73);
            this.txtControlName.Name = "txtControlName";
            this.txtControlName.Size = new System.Drawing.Size(242, 31);
            this.txtControlName.TabIndex = 12;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(17, 38);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(127, 29);
            this.kryptonLabel1.TabIndex = 11;
            this.kryptonLabel1.Values.Text = "Control Name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(169, 135);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 37);
            this.btnSave.TabIndex = 10;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvControlForm
            // 
            this.dgvControlForm.AllowUserToAddRows = false;
            this.dgvControlForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControlForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colControlId,
            this.colControlForm,
            this.colIsActive,
            this.colEdit,
            this.colDel});
            this.dgvControlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvControlForm.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dgvControlForm.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderRowList;
            this.dgvControlForm.Location = new System.Drawing.Point(274, 0);
            this.dgvControlForm.Name = "dgvControlForm";
            this.dgvControlForm.RowHeadersWidth = 50;
            this.dgvControlForm.RowTemplate.Height = 28;
            this.dgvControlForm.Size = new System.Drawing.Size(565, 669);
            this.dgvControlForm.TabIndex = 1;
            this.dgvControlForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvControlForm_CellContentClick);
            this.dgvControlForm.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvControlForm_DataBindingComplete);
            // 
            // colControlId
            // 
            this.colControlId.DataPropertyName = "ControlId";
            this.colControlId.HeaderText = "ControlId";
            this.colControlId.MinimumWidth = 8;
            this.colControlId.Name = "colControlId";
            this.colControlId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colControlId.Visible = false;
            this.colControlId.Width = 150;
            // 
            // colControlForm
            // 
            this.colControlForm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colControlForm.DataPropertyName = "ControlForm";
            this.colControlForm.HeaderText = "ControlForm";
            this.colControlForm.MinimumWidth = 8;
            this.colControlForm.Name = "colControlForm";
            this.colControlForm.ReadOnly = true;
            this.colControlForm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colControlForm.Width = 322;
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
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 669);
            this.Controls.Add(this.dgvControlForm);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "ControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlForm";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvControlForm;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtControlName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn colControlId;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn colControlForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsActive;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn colEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn colDel;
    }
}