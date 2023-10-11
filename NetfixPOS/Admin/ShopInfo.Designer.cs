
namespace NetfixPOS.Admin
{
    partial class ShopInfo
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
            this.btnShopUpdate = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtService = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpSaleDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtShopName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.dgvSoftwareInfo = new System.Windows.Forms.DataGridView();
            this.colGeneral_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShopId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActivateKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServiceTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtRoomService = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoftwareInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnShopUpdate);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtPhoneNo);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtShopName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAddImage);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 655);
            this.panel1.TabIndex = 0;
            // 
            // btnShopUpdate
            // 
            this.btnShopUpdate.Location = new System.Drawing.Point(414, 245);
            this.btnShopUpdate.Name = "btnShopUpdate";
            this.btnShopUpdate.Size = new System.Drawing.Size(96, 43);
            this.btnShopUpdate.TabIndex = 13;
            this.btnShopUpdate.Text = "Update";
            this.btnShopUpdate.UseVisualStyleBackColor = true;
            this.btnShopUpdate.Click += new System.EventHandler(this.btnShopUpdate_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(260, 189);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(268, 26);
            this.txtEmail.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Email";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRoomService);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDiscount);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtService);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpSaleDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtKey);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 315);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Software Info";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(372, 207);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(137, 26);
            this.txtDiscount.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Inv-Discount";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(416, 257);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 43);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(372, 142);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(137, 26);
            this.txtService.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Service Tax";
            // 
            // dtpSaleDate
            // 
            this.dtpSaleDate.Location = new System.Drawing.Point(112, 92);
            this.dtpSaleDate.Name = "dtpSaleDate";
            this.dtpSaleDate.Size = new System.Drawing.Size(397, 26);
            this.dtpSaleDate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "SaleDate";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(112, 49);
            this.txtKey.Name = "txtKey";
            this.txtKey.ReadOnly = true;
            this.txtKey.Size = new System.Drawing.Size(397, 26);
            this.txtKey.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Key";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(260, 148);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(268, 26);
            this.txtPhoneNo.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(260, 68);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(268, 70);
            this.txtAddress.TabIndex = 6;
            // 
            // txtShopName
            // 
            this.txtShopName.Location = new System.Drawing.Point(260, 25);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(268, 26);
            this.txtShopName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shop Name";
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(10, 138);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(142, 32);
            this.btnAddImage.TabIndex = 1;
            this.btnAddImage.Text = "Add Logo";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(10, 11);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(142, 126);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // dgvSoftwareInfo
            // 
            this.dgvSoftwareInfo.AllowUserToAddRows = false;
            this.dgvSoftwareInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoftwareInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGeneral_Id,
            this.colShopId,
            this.colActivateKey,
            this.colSaleDate,
            this.colServiceTax,
            this.colRoomService,
            this.colInvDiscount,
            this.colIsActive,
            this.colEdit});
            this.dgvSoftwareInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSoftwareInfo.Location = new System.Drawing.Point(532, 0);
            this.dgvSoftwareInfo.Name = "dgvSoftwareInfo";
            this.dgvSoftwareInfo.RowHeadersWidth = 62;
            this.dgvSoftwareInfo.Size = new System.Drawing.Size(863, 655);
            this.dgvSoftwareInfo.TabIndex = 1;
            this.dgvSoftwareInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSoftwareInfo_CellContentClick);
            // 
            // colGeneral_Id
            // 
            this.colGeneral_Id.DataPropertyName = "General_Id";
            this.colGeneral_Id.HeaderText = "General_Id";
            this.colGeneral_Id.MinimumWidth = 8;
            this.colGeneral_Id.Name = "colGeneral_Id";
            this.colGeneral_Id.Visible = false;
            this.colGeneral_Id.Width = 150;
            // 
            // colShopId
            // 
            this.colShopId.DataPropertyName = "ShopId";
            this.colShopId.HeaderText = "ShopId";
            this.colShopId.MinimumWidth = 8;
            this.colShopId.Name = "colShopId";
            this.colShopId.Visible = false;
            this.colShopId.Width = 150;
            // 
            // colActivateKey
            // 
            this.colActivateKey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colActivateKey.DataPropertyName = "ActivateKey";
            this.colActivateKey.HeaderText = "ActivateKey";
            this.colActivateKey.MinimumWidth = 8;
            this.colActivateKey.Name = "colActivateKey";
            this.colActivateKey.ReadOnly = true;
            this.colActivateKey.Visible = false;
            // 
            // colSaleDate
            // 
            this.colSaleDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSaleDate.DataPropertyName = "SaleDate";
            this.colSaleDate.FillWeight = 60F;
            this.colSaleDate.HeaderText = "SaleDate";
            this.colSaleDate.MinimumWidth = 8;
            this.colSaleDate.Name = "colSaleDate";
            this.colSaleDate.ReadOnly = true;
            // 
            // colServiceTax
            // 
            this.colServiceTax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colServiceTax.DataPropertyName = "ServiceTax";
            this.colServiceTax.FillWeight = 50F;
            this.colServiceTax.HeaderText = "ServiceTax";
            this.colServiceTax.MinimumWidth = 8;
            this.colServiceTax.Name = "colServiceTax";
            this.colServiceTax.ReadOnly = true;
            // 
            // colRoomService
            // 
            this.colRoomService.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRoomService.DataPropertyName = "RoomService";
            this.colRoomService.FillWeight = 50F;
            this.colRoomService.HeaderText = "RoomService";
            this.colRoomService.MinimumWidth = 8;
            this.colRoomService.Name = "colRoomService";
            this.colRoomService.ReadOnly = true;
            // 
            // colInvDiscount
            // 
            this.colInvDiscount.DataPropertyName = "InvDiscount";
            this.colInvDiscount.HeaderText = "Inv-Discount";
            this.colInvDiscount.MinimumWidth = 8;
            this.colInvDiscount.Name = "colInvDiscount";
            this.colInvDiscount.ReadOnly = true;
            this.colInvDiscount.Width = 150;
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
            // txtRoomService
            // 
            this.txtRoomService.Location = new System.Drawing.Point(372, 174);
            this.txtRoomService.Name = "txtRoomService";
            this.txtRoomService.Size = new System.Drawing.Size(137, 26);
            this.txtRoomService.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Room Service";
            // 
            // ShopInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 655);
            this.Controls.Add(this.dgvSoftwareInfo);
            this.Controls.Add(this.panel1);
            this.Name = "ShopInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoftwareInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtShopName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpSaleDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvSoftwareInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShopUpdate;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGeneral_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShopId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActivateKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomService;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsActive;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.TextBox txtRoomService;
        private System.Windows.Forms.Label label9;
    }
}