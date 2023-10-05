
namespace NetfixPOS.Admin
{
    partial class Employee
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
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.dtpJoinDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBirthPlace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.picEmployee = new System.Windows.Forms.PictureBox();
            this.txtEnrollNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.colEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colEnrollNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirthPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJoinDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoFemale);
            this.panel1.Controls.Add(this.rdoMale);
            this.panel1.Controls.Add(this.cboDepartment);
            this.panel1.Controls.Add(this.dtpJoinDate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtBirthPlace);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.picEmployee);
            this.panel1.Controls.Add(this.txtEnrollNumber);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPhoneNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtEmployeeName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 687);
            this.panel1.TabIndex = 2;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(232, 85);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(87, 24);
            this.rdoFemale.TabIndex = 115;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            this.rdoFemale.CheckedChanged += new System.EventHandler(this.rdoFemale_CheckedChanged);
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(232, 55);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(68, 24);
            this.rdoMale.TabIndex = 114;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            this.rdoMale.CheckedChanged += new System.EventHandler(this.rdoMale_CheckedChanged);
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(146, 467);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(226, 28);
            this.cboDepartment.TabIndex = 113;
            // 
            // dtpJoinDate
            // 
            this.dtpJoinDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpJoinDate.Location = new System.Drawing.Point(146, 430);
            this.dtpJoinDate.Name = "dtpJoinDate";
            this.dtpJoinDate.Size = new System.Drawing.Size(226, 26);
            this.dtpJoinDate.TabIndex = 112;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 430);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 111;
            this.label6.Text = "Join Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 470);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 110;
            this.label5.Text = "Department";
            // 
            // txtBirthPlace
            // 
            this.txtBirthPlace.Location = new System.Drawing.Point(146, 304);
            this.txtBirthPlace.Margin = new System.Windows.Forms.Padding(4);
            this.txtBirthPlace.Multiline = true;
            this.txtBirthPlace.Name = "txtBirthPlace";
            this.txtBirthPlace.Size = new System.Drawing.Size(226, 75);
            this.txtBirthPlace.TabIndex = 109;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 108;
            this.label4.Text = "Birth Place";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(33, 168);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 31);
            this.btnAdd.TabIndex = 107;
            this.btnAdd.Text = "Add Image";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // picEmployee
            // 
            this.picEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEmployee.Location = new System.Drawing.Point(33, 12);
            this.picEmployee.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picEmployee.Name = "picEmployee";
            this.picEmployee.Size = new System.Drawing.Size(160, 153);
            this.picEmployee.TabIndex = 106;
            this.picEmployee.TabStop = false;
            // 
            // txtEnrollNumber
            // 
            this.txtEnrollNumber.Location = new System.Drawing.Point(146, 235);
            this.txtEnrollNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnrollNumber.Name = "txtEnrollNumber";
            this.txtEnrollNumber.Size = new System.Drawing.Size(226, 26);
            this.txtEnrollNumber.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Enroll Number";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(146, 387);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(226, 26);
            this.txtPhoneNo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 388);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Phone No";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(146, 269);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(226, 26);
            this.txtEmployeeName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 271);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Employee Name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(146, 558);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 37);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmpId,
            this.colEmpImage,
            this.colEnrollNumber,
            this.colEmpName,
            this.colPhoneNo,
            this.colBirthPlace,
            this.colJoinDate,
            this.colGender,
            this.colDepartment,
            this.colDepartmentId,
            this.colIsActive,
            this.colEdit,
            this.colDel});
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployee.Location = new System.Drawing.Point(387, 0);
            this.dgvEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 50;
            this.dgvEmployee.RowTemplate.Height = 100;
            this.dgvEmployee.Size = new System.Drawing.Size(1322, 687);
            this.dgvEmployee.TabIndex = 5;
            this.dgvEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellContentClick);
            this.dgvEmployee.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvUser_DataBindingComplete);
            // 
            // colEmpId
            // 
            this.colEmpId.DataPropertyName = "EmpId";
            this.colEmpId.HeaderText = "EmpId";
            this.colEmpId.MinimumWidth = 8;
            this.colEmpId.Name = "colEmpId";
            this.colEmpId.Visible = false;
            this.colEmpId.Width = 150;
            // 
            // colEmpImage
            // 
            this.colEmpImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmpImage.DataPropertyName = "EmpImage";
            this.colEmpImage.FillWeight = 80F;
            this.colEmpImage.HeaderText = "Image";
            this.colEmpImage.MinimumWidth = 8;
            this.colEmpImage.Name = "colEmpImage";
            // 
            // colEnrollNumber
            // 
            this.colEnrollNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEnrollNumber.DataPropertyName = "EnrollNumber";
            this.colEnrollNumber.HeaderText = "EnrollNumber";
            this.colEnrollNumber.MinimumWidth = 8;
            this.colEnrollNumber.Name = "colEnrollNumber";
            // 
            // colEmpName
            // 
            this.colEmpName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmpName.DataPropertyName = "EmpName";
            this.colEmpName.FillWeight = 80F;
            this.colEmpName.HeaderText = "Employee Name";
            this.colEmpName.MinimumWidth = 8;
            this.colEmpName.Name = "colEmpName";
            // 
            // colPhoneNo
            // 
            this.colPhoneNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPhoneNo.DataPropertyName = "PhoneNo";
            this.colPhoneNo.FillWeight = 50F;
            this.colPhoneNo.HeaderText = "Phone";
            this.colPhoneNo.MinimumWidth = 8;
            this.colPhoneNo.Name = "colPhoneNo";
            // 
            // colBirthPlace
            // 
            this.colBirthPlace.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBirthPlace.DataPropertyName = "BirthPlace";
            this.colBirthPlace.HeaderText = "BirthPlace";
            this.colBirthPlace.MinimumWidth = 8;
            this.colBirthPlace.Name = "colBirthPlace";
            // 
            // colJoinDate
            // 
            this.colJoinDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colJoinDate.DataPropertyName = "JoinDate";
            this.colJoinDate.HeaderText = "Join Date";
            this.colJoinDate.MinimumWidth = 8;
            this.colJoinDate.Name = "colJoinDate";
            // 
            // colGender
            // 
            this.colGender.DataPropertyName = "Gender";
            this.colGender.HeaderText = "Gender";
            this.colGender.MinimumWidth = 8;
            this.colGender.Name = "colGender";
            this.colGender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colGender.Visible = false;
            this.colGender.Width = 150;
            // 
            // colDepartment
            // 
            this.colDepartment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDepartment.DataPropertyName = "DepartmentName";
            this.colDepartment.HeaderText = "Department";
            this.colDepartment.MinimumWidth = 8;
            this.colDepartment.Name = "colDepartment";
            // 
            // colDepartmentId
            // 
            this.colDepartmentId.DataPropertyName = "DepartmentId";
            this.colDepartmentId.HeaderText = "DepartmentId";
            this.colDepartmentId.MinimumWidth = 8;
            this.colDepartmentId.Name = "colDepartmentId";
            this.colDepartmentId.Visible = false;
            this.colDepartmentId.Width = 150;
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
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 687);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.panel1);
            this.Name = "Employee";
            this.Text = "Employee";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBirthPlace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox picEmployee;
        private System.Windows.Forms.TextBox txtEnrollNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpJoinDate;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpId;
        private System.Windows.Forms.DataGridViewImageColumn colEmpImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnrollNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirthPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJoinDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsActive;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDel;
    }
}