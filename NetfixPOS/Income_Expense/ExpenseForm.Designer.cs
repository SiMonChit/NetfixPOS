
namespace NetfixPOS.Income_Expense
{
    partial class ExpenseForm
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
            this.dtpIn_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvExpnse = new System.Windows.Forms.DataGridView();
            this.colExpenseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEx_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEx_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEx_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpnse)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpIn_date);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 440);
            this.panel1.TabIndex = 4;
            // 
            // dtpIn_date
            // 
            this.dtpIn_date.Location = new System.Drawing.Point(69, 105);
            this.dtpIn_date.Margin = new System.Windows.Forms.Padding(2);
            this.dtpIn_date.Name = "dtpIn_date";
            this.dtpIn_date.Size = new System.Drawing.Size(180, 20);
            this.dtpIn_date.TabIndex = 112;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 111;
            this.label6.Text = "Date";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(69, 12);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(180, 50);
            this.txtDescription.TabIndex = 109;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 108;
            this.label4.Text = "Description";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(69, 71);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(180, 20);
            this.txtAmount.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Amount";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(182, 139);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 24);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvExpnse
            // 
            this.dgvExpnse.AllowUserToAddRows = false;
            this.dgvExpnse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpnse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colExpenseId,
            this.colEx_Description,
            this.colEx_Date,
            this.colEx_Amount,
            this.colIsActive,
            this.colUserID,
            this.colEdit,
            this.colDel});
            this.dgvExpnse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExpnse.Location = new System.Drawing.Point(258, 0);
            this.dgvExpnse.Name = "dgvExpnse";
            this.dgvExpnse.RowHeadersWidth = 30;
            this.dgvExpnse.Size = new System.Drawing.Size(533, 440);
            this.dgvExpnse.TabIndex = 5;
            // 
            // colExpenseId
            // 
            this.colExpenseId.DataPropertyName = "ExpenseId";
            this.colExpenseId.HeaderText = "ExpenseId";
            this.colExpenseId.Name = "colExpenseId";
            this.colExpenseId.Visible = false;
            // 
            // colEx_Description
            // 
            this.colEx_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEx_Description.DataPropertyName = "Ex_Description";
            this.colEx_Description.HeaderText = "Description";
            this.colEx_Description.Name = "colEx_Description";
            this.colEx_Description.ReadOnly = true;
            // 
            // colEx_Date
            // 
            this.colEx_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEx_Date.DataPropertyName = "Ex_Date";
            this.colEx_Date.FillWeight = 40F;
            this.colEx_Date.HeaderText = "Date";
            this.colEx_Date.Name = "colEx_Date";
            this.colEx_Date.ReadOnly = true;
            // 
            // colEx_Amount
            // 
            this.colEx_Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEx_Amount.DataPropertyName = "Ex_Amount";
            this.colEx_Amount.FillWeight = 40F;
            this.colEx_Amount.HeaderText = "Amount";
            this.colEx_Amount.Name = "colEx_Amount";
            this.colEx_Amount.ReadOnly = true;
            // 
            // colIsActive
            // 
            this.colIsActive.DataPropertyName = "InActive";
            this.colIsActive.HeaderText = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = false;
            // 
            // colUserID
            // 
            this.colUserID.DataPropertyName = "UserID";
            this.colUserID.HeaderText = "UserID";
            this.colUserID.Name = "colUserID";
            this.colUserID.Visible = false;
            // 
            // colEdit
            // 
            this.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEdit.FillWeight = 30F;
            this.colEdit.HeaderText = "Edit";
            this.colEdit.Name = "colEdit";
            this.colEdit.Text = "Edit";
            this.colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDel
            // 
            this.colDel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDel.FillWeight = 30F;
            this.colDel.HeaderText = "Delete";
            this.colDel.Name = "colDel";
            this.colDel.Text = "Delete";
            this.colDel.UseColumnTextForButtonValue = true;
            // 
            // ExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 440);
            this.Controls.Add(this.dgvExpnse);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ExpenseForm";
            this.Text = "Expense";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpnse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpIn_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvExpnse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpenseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEx_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEx_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEx_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserID;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDel;
    }
}