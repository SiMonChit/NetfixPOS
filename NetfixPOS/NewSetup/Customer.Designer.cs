
namespace NetfixPOS.NewSetup
{
    partial class Customer
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
            this.txtCurrentAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkIsDefault = new System.Windows.Forms.CheckBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.colCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsDefault = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCurrentAddress);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCustomerName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chkIsDefault);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 663);
            this.panel1.TabIndex = 0;
            // 
            // txtCurrentAddress
            // 
            this.txtCurrentAddress.Location = new System.Drawing.Point(153, 202);
            this.txtCurrentAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurrentAddress.Multiline = true;
            this.txtCurrentAddress.Name = "txtCurrentAddress";
            this.txtCurrentAddress.Size = new System.Drawing.Size(226, 101);
            this.txtCurrentAddress.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Current Address";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(153, 101);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(226, 26);
            this.txtCustomerName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Customer Name";
            // 
            // chkIsDefault
            // 
            this.chkIsDefault.AutoSize = true;
            this.chkIsDefault.Location = new System.Drawing.Point(153, 310);
            this.chkIsDefault.Name = "chkIsDefault";
            this.chkIsDefault.Size = new System.Drawing.Size(100, 24);
            this.chkIsDefault.TabIndex = 11;
            this.chkIsDefault.Text = "IsDefault";
            this.chkIsDefault.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(153, 169);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(226, 26);
            this.txtPhone.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Phone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(153, 135);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(226, 26);
            this.txtEmail.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Email";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(153, 362);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 37);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustomerId,
            this.colCustomerName,
            this.colEmail,
            this.colPhone,
            this.colCurrentAddress,
            this.colIsDefault,
            this.colIsActive,
            this.colEdit,
            this.colDel});
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.Location = new System.Drawing.Point(387, 0);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 50;
            this.dgvCustomer.RowTemplate.Height = 28;
            this.dgvCustomer.Size = new System.Drawing.Size(1156, 663);
            this.dgvCustomer.TabIndex = 3;
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            this.dgvCustomer.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCustomer_DataBindingComplete);
            // 
            // colCustomerId
            // 
            this.colCustomerId.DataPropertyName = "CustomerId";
            this.colCustomerId.HeaderText = "CustomerId";
            this.colCustomerId.MinimumWidth = 8;
            this.colCustomerId.Name = "colCustomerId";
            this.colCustomerId.Visible = false;
            this.colCustomerId.Width = 150;
            // 
            // colCustomerName
            // 
            this.colCustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCustomerName.DataPropertyName = "CustomerName";
            this.colCustomerName.HeaderText = "Customer Name";
            this.colCustomerName.MinimumWidth = 8;
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.FillWeight = 80F;
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 8;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPhone.DataPropertyName = "Phone";
            this.colPhone.FillWeight = 50F;
            this.colPhone.HeaderText = "Phone";
            this.colPhone.MinimumWidth = 8;
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // colCurrentAddress
            // 
            this.colCurrentAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCurrentAddress.DataPropertyName = "CurrentAddress";
            this.colCurrentAddress.HeaderText = "Current Address";
            this.colCurrentAddress.MinimumWidth = 8;
            this.colCurrentAddress.Name = "colCurrentAddress";
            this.colCurrentAddress.ReadOnly = true;
            // 
            // colIsDefault
            // 
            this.colIsDefault.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colIsDefault.DataPropertyName = "IsDefault";
            this.colIsDefault.FillWeight = 50F;
            this.colIsDefault.HeaderText = "Is Default";
            this.colIsDefault.MinimumWidth = 8;
            this.colIsDefault.Name = "colIsDefault";
            this.colIsDefault.ReadOnly = true;
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
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1543, 663);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.panel1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.CheckBox chkIsDefault;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCurrentAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentAddress;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsDefault;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsActive;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDel;
    }
}