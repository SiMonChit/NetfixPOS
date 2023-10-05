
namespace NetfixPOS.Admin
{
    partial class AutoGenerate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpGenerateDate = new System.Windows.Forms.DateTimePicker();
            this.txtLastValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGenerateNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGenerateType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvAutoGenerate = new System.Windows.Forms.DataGridView();
            this.colGenerateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenerateNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenerateType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenerateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoGenerate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpGenerateDate);
            this.panel1.Controls.Add(this.txtLastValue);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtGenerateNo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtGenerateType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 637);
            this.panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 165);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(226, 26);
            this.textBox1.TabIndex = 112;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 111;
            this.label5.Text = "Result";
            // 
            // dtpGenerateDate
            // 
            this.dtpGenerateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGenerateDate.Location = new System.Drawing.Point(153, 118);
            this.dtpGenerateDate.Name = "dtpGenerateDate";
            this.dtpGenerateDate.Size = new System.Drawing.Size(226, 26);
            this.dtpGenerateDate.TabIndex = 110;
            // 
            // txtLastValue
            // 
            this.txtLastValue.Location = new System.Drawing.Point(153, 82);
            this.txtLastValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastValue.Name = "txtLastValue";
            this.txtLastValue.Size = new System.Drawing.Size(226, 26);
            this.txtLastValue.TabIndex = 109;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 108;
            this.label4.Text = "LastValue";
            // 
            // txtGenerateNo
            // 
            this.txtGenerateNo.Location = new System.Drawing.Point(153, 13);
            this.txtGenerateNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenerateNo.Name = "txtGenerateNo";
            this.txtGenerateNo.Size = new System.Drawing.Size(226, 26);
            this.txtGenerateNo.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Generate No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "GenerateDate";
            // 
            // txtGenerateType
            // 
            this.txtGenerateType.Location = new System.Drawing.Point(153, 47);
            this.txtGenerateType.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenerateType.Name = "txtGenerateType";
            this.txtGenerateType.Size = new System.Drawing.Size(226, 26);
            this.txtGenerateType.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Generate Type";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(153, 237);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 37);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvAutoGenerate
            // 
            this.dgvAutoGenerate.AllowUserToAddRows = false;
            this.dgvAutoGenerate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutoGenerate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGenerateID,
            this.colGenerateNo,
            this.colLastValue,
            this.colGenerateType,
            this.colGenerateDate,
            this.colEdit,
            this.colDel});
            this.dgvAutoGenerate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAutoGenerate.Location = new System.Drawing.Point(406, 0);
            this.dgvAutoGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAutoGenerate.Name = "dgvAutoGenerate";
            this.dgvAutoGenerate.RowHeadersWidth = 50;
            this.dgvAutoGenerate.RowTemplate.Height = 25;
            this.dgvAutoGenerate.Size = new System.Drawing.Size(775, 637);
            this.dgvAutoGenerate.TabIndex = 5;
            this.dgvAutoGenerate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutoGenerate_CellContentClick);
            // 
            // colGenerateID
            // 
            this.colGenerateID.DataPropertyName = "GenerateID";
            this.colGenerateID.HeaderText = "GenerateID";
            this.colGenerateID.MinimumWidth = 8;
            this.colGenerateID.Name = "colGenerateID";
            this.colGenerateID.Visible = false;
            this.colGenerateID.Width = 150;
            // 
            // colGenerateNo
            // 
            this.colGenerateNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGenerateNo.DataPropertyName = "GenerateNo";
            this.colGenerateNo.FillWeight = 80F;
            this.colGenerateNo.HeaderText = "GenerateNo";
            this.colGenerateNo.MinimumWidth = 8;
            this.colGenerateNo.Name = "colGenerateNo";
            // 
            // colLastValue
            // 
            this.colLastValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLastValue.DataPropertyName = "LastValue";
            this.colLastValue.FillWeight = 50F;
            this.colLastValue.HeaderText = "LastValue";
            this.colLastValue.MinimumWidth = 8;
            this.colLastValue.Name = "colLastValue";
            // 
            // colGenerateType
            // 
            this.colGenerateType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGenerateType.DataPropertyName = "GenerateType";
            this.colGenerateType.HeaderText = "Generate Type";
            this.colGenerateType.MinimumWidth = 8;
            this.colGenerateType.Name = "colGenerateType";
            this.colGenerateType.ReadOnly = true;
            // 
            // colGenerateDate
            // 
            this.colGenerateDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGenerateDate.DataPropertyName = "GenerateDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.colGenerateDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colGenerateDate.HeaderText = "GenerateDate";
            this.colGenerateDate.MinimumWidth = 8;
            this.colGenerateDate.Name = "colGenerateDate";
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
            // AutoGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 637);
            this.Controls.Add(this.dgvAutoGenerate);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AutoGenerate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoGenerate";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoGenerate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLastValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGenerateNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGenerateType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvAutoGenerate;
        private System.Windows.Forms.DateTimePicker dtpGenerateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenerateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenerateNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenerateType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenerateDate;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}