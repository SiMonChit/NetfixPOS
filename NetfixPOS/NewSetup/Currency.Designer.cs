
namespace NetfixPOS.NewSetup
{
    partial class Currency
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
            this.chkIsDefault = new System.Windows.Forms.CheckBox();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvCurrency = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.colCurrencyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsDefault = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrency)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.chkIsDefault);
            this.panel1.Controls.Add(this.txtSymbol);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCurrency);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 51);
            this.panel1.TabIndex = 1;
            // 
            // chkIsDefault
            // 
            this.chkIsDefault.AutoSize = true;
            this.chkIsDefault.Location = new System.Drawing.Point(403, 13);
            this.chkIsDefault.Name = "chkIsDefault";
            this.chkIsDefault.Size = new System.Drawing.Size(82, 21);
            this.chkIsDefault.TabIndex = 5;
            this.chkIsDefault.Text = "IsDefault";
            this.chkIsDefault.UseVisualStyleBackColor = true;
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(301, 12);
            this.txtSymbol.Margin = new System.Windows.Forms.Padding(4);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(63, 23);
            this.txtSymbol.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Symbol";
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(86, 12);
            this.txtCurrency.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(136, 23);
            this.txtCurrency.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Currency";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(508, 5);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvCurrency
            // 
            this.dgvCurrency.AllowUserToAddRows = false;
            this.dgvCurrency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrency.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCurrencyId,
            this.colCurrency,
            this.colSymbol,
            this.colIsDefault,
            this.colEdit,
            this.colDel});
            this.dgvCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCurrency.Location = new System.Drawing.Point(0, 51);
            this.dgvCurrency.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCurrency.Name = "dgvCurrency";
            this.dgvCurrency.RowHeadersWidth = 50;
            this.dgvCurrency.RowTemplate.Height = 28;
            this.dgvCurrency.Size = new System.Drawing.Size(678, 422);
            this.dgvCurrency.TabIndex = 2;
            this.dgvCurrency.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurrency_CellContentClick);
            this.dgvCurrency.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCurrency_DataBindingComplete);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(594, 5);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(78, 30);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // colCurrencyId
            // 
            this.colCurrencyId.DataPropertyName = "CurrencyId";
            this.colCurrencyId.HeaderText = "CurrencyId";
            this.colCurrencyId.MinimumWidth = 8;
            this.colCurrencyId.Name = "colCurrencyId";
            this.colCurrencyId.Visible = false;
            this.colCurrencyId.Width = 150;
            // 
            // colCurrency
            // 
            this.colCurrency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCurrency.DataPropertyName = "Currency";
            this.colCurrency.HeaderText = "Currency";
            this.colCurrency.MinimumWidth = 8;
            this.colCurrency.Name = "colCurrency";
            // 
            // colSymbol
            // 
            this.colSymbol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSymbol.DataPropertyName = "Symbol";
            this.colSymbol.FillWeight = 80F;
            this.colSymbol.HeaderText = "Symbol";
            this.colSymbol.MinimumWidth = 8;
            this.colSymbol.Name = "colSymbol";
            // 
            // colIsDefault
            // 
            this.colIsDefault.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colIsDefault.DataPropertyName = "IsDefault";
            this.colIsDefault.FillWeight = 50F;
            this.colIsDefault.HeaderText = "Default";
            this.colIsDefault.Name = "colIsDefault";
            this.colIsDefault.ReadOnly = true;
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
            // Currency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 473);
            this.Controls.Add(this.dgvCurrency);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Currency";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkIsDefault;
        private System.Windows.Forms.DataGridView dgvCurrency;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrencyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSymbol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsDefault;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDel;
    }
}